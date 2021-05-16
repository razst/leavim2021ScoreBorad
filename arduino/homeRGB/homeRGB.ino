// NeoPixel Ring simple sketch (c) 2013 Shae Erisson
// released under the GPLv3 license to match the rest of the AdaFruit NeoPixel library

#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
#include <avr/power.h>
#endif

const int LDR0 = A0;
const int LDR1 = A1;
const int LDR2 = A2;
const int LDR3 = A3;
int incomingByte = 0; // for incoming serial data


// Which pin on the Arduino is connected to the NeoPixels?
// On a Trinket or Gemma we suggest changing this to 1
#define PIN_LEDS          6
// How many NeoPixels are attached to the Arduino?
#define NUMPIXELS      12
#define NUMLEDPERWIN   3
#define TIME_PER_PLAY 60000*1
#define LAZER_VALUE_CHANGE  40 // from this value and up, we consider as lazsr hit

Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUMPIXELS, PIN_LEDS, NEO_GRB + NEO_KHZ800);

int delayval = 100; // delay for half a second
int activeWin;
int lastwin = -1;
int pre_ldr_value[4] = {0, 0, 0, 0};
unsigned long timeStartPlay = 0;
int score = 0;




void lightWin(int win, int r, int g, int b)
{
  if (activeWin == 0) {
    light(0, r, g, b);
  }
  if (activeWin == 1) {
    light(3, r, g, b);
  }

  if (activeWin == 2) {
    light(6, r, g, b);
  }
  if (activeWin == 3) {
    light(9, r, g, b);

  }
}

void light(int startPix, int r, int g, int b) {

  Serial.print("about to light:");
  Serial.println(startPix);
  for (int i = startPix; i < startPix + NUMLEDPERWIN; i++) {
    // pixels.Color takes RGB values, from 0,0,0 up to 255,255,255
    pixels.setPixelColor(i, pixels.Color(r, g, b)); // Moderately bright green color.
    delay(delayval); // Delay for a period of time (in milliseconds).
  }
  pixels.show(); // This sends the updated pixel color to the hardware.
}

boolean checkLDRs() {
  boolean isHit = false;
  int Read_val[4] = {analogRead(LDR0), analogRead(LDR1), analogRead(LDR2), analogRead(LDR3)};
  for (int i = 0; i < 4; i++) // i = index of all windows 0-4
  {
//    Serial.print("Read_val[");
//    Serial.print(i);
//    Serial.print("]:");
//    Serial.println(Read_val[1]);
//    Serial.print("pre_ldr_value: ");
//    Serial.println(pre_ldr_value[1]);
    if (pre_ldr_value[i] == 0) { // first time
      pre_ldr_value[i] = Read_val[i];
    }
    else {

      if (Read_val[i] - pre_ldr_value[i] > LAZER_VALUE_CHANGE) {
        delay(10);
        if (i == 0) {
          Read_val[i] = analogRead(LDR0);
        }
        if (i == 1) {
          Read_val[i] = analogRead(LDR1);
        }
        if (i == 2) {
          Read_val[i] = analogRead(LDR2);
        }
        if (i == 3) {
          Read_val[i] = analogRead(LDR3);
        }

        if (Read_val[i] - pre_ldr_value[i] > LAZER_VALUE_CHANGE) {

          Serial.println("Read_val[i] - pre_ldr_value[i]:");
          Serial.println(Read_val[i] - pre_ldr_value[i]);
          Serial.println(Read_val[i]);
          Serial.println(pre_ldr_value[i]);
          if (activeWin == i) // if we got a hit on the active window
          {
            score = score + 10;
            sendInfoToGUI();
            fillLEDAndBlink(pixels.Color(0, 255, 0), 0, NUMPIXELS, 3000);
            fillLEDAndSleep(pixels.Color(255, 255, 255), 0, NUMPIXELS, 0);
            isHit  = true;
          }
          else // hit on not active window
          {
            if (score > 0) {
              score = score - 10;
            }
            sendInfoToGUI();
            fillLEDAndBlink(pixels.Color(0, 0, 255), 0, NUMPIXELS, 3000);
            fillLEDAndSleep(pixels.Color(255, 255, 255), 0, NUMPIXELS, 0);
            lightWin(activeWin, 255, 0, 0);
          }
        }
      }
      pre_ldr_value[i] = Read_val[i];
    }
  }
  return isHit;
}


void fillLEDAndBlink(uint32_t color, uint16_t first, uint16_t count, int delay_t) {

  unsigned long startMillis = millis();  //initial start time
  while (millis() - startMillis <= delay_t) {
    fillLEDAndSleep(color, 0, NUMPIXELS, 0);  
    delay(300);
    fillLEDAndSleep(pixels.Color(0, 0, 0), 0, NUMPIXELS, 0);
    delay(100);  
  }
  
}


void fillLEDAndSleep(uint32_t color, uint16_t first, uint16_t count, int delay_t) {

  pixels.fill(color, first, count);
  pixels.show();
  delay(delay_t);
}

void setup() {
  // This is for Trinket 5V 16MHz, you can remove these three lines if you are not using a Trinket
#if defined (__AVR_ATtiny85__)
  if (F_CPU == 16000000) clock_prescale_set(clock_div_1);
#endif
  // End of trinket special code
  Serial.begin(9600);
  pixels.begin(); // This initializes the NeoPixel library.
  randomSeed(analogRead(0));
  Serial.println("start");
  fillLEDAndSleep(pixels.Color(255, 255, 255), 0, NUMPIXELS, 0);


}

int findRandWIn() {
  activeWin = random(4);
  Serial.print("first rand");
  Serial.println(activeWin);

  while (activeWin == lastwin) {
    Serial.println("activeWin == lastwin");
    activeWin = random(4);
  }
//  activeWin=1;
  Serial.print("second rand");
  Serial.println(activeWin);
  lastwin = activeWin;

  pre_ldr_value[activeWin] = 0;
  fillLEDAndSleep(pixels.Color(255, 255, 255), 0, NUMPIXELS, 0);
  lightWin(activeWin, 255, 0, 0);
}

bool checkStopGame(){
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingByte = Serial.read();
    if (incomingByte == 69) { // we got the "S" latter
      return true;
    }
  }
  return false;
}

void sendInfoToGUI(){
    // send info to control GUI
    Serial.print(millis()-timeStartPlay);
    Serial.print(",");
    Serial.println(score);  
}

void startPlay() {
  Serial.println("0,0"); // send zeros to GUI
  fillLEDAndSleep(pixels.Color(255, 0, 0), 0, NUMPIXELS, 3000);
  fillLEDAndSleep(pixels.Color(255, 255, 0), 0, NUMPIXELS, 3000);
  fillLEDAndBlink(pixels.Color(0, 255, 0), 0, NUMPIXELS, 3000);
  score=0;
  timeStartPlay = millis();  //initial start time
  findRandWIn();
  while (millis() - timeStartPlay <= TIME_PER_PLAY) {
    sendInfoToGUI();
    if (checkLDRs()) {
      findRandWIn();
    }
    if (checkStopGame()){
      break;
    }
    delay(10);
  }

}

void loop() {

  // wait for a signal to start game...
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingByte = Serial.read();
    if (incomingByte == 83) { // we got the "S" latter
      startPlay();
    }
  }
  // game ended, show white LEDs
  fillLEDAndSleep(pixels.Color(255, 255, 255), 0, NUMPIXELS, 0);
  delay(50);
}
