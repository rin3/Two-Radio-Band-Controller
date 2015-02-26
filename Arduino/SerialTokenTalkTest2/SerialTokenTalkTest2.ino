void setup() {
  pinMode(13, OUTPUT);
  digitalWrite(13, LOW);
  Serial.begin(38400);

  boolean boolConnected = false;
}

void loop() {
  if (!boolConnected) {
    // send parameters
    sendParam();
  }

  char cBuf[20];
  if (Serial.available() > 0) {
    if (Serial.readBytes(cBuf, 9) == 9) {
      if ((String)cBuf == "ACKdeVGX\n") {
        boolConnected = true;
      }
    } 
  }
  delay(200);
}

// send parameters
void sendParam() {
  Serial.print("ZUYmaster");
  Serial.print("0.3");
  // parameters
  Serial.write(0); //Kenwood
  Serial.write(1); //ICOM
  Serial.write(0x7A);  //ZUY Hex
  Serial.write(0x6E);  //L Exc Hex
  Serial.write(0x7A);  //R Exc Hex
  Serial.write(0x54);  //L Amp Hex
  Serial.write(0x54);  //R Amp Hex
  Serial.write(3); //L Exc Speed
  Serial.write(3); //R EXc Speed
  Serial.write(3); //L Amp Speed
  Serial.write(3); //R Amp Speed
  Serial.write(1); //L Exc Parameters
  Serial.write(1); //R Exc Parameters
  Serial.write(1); //L Amp Parameters
  Serial.write(1); //R Amp Parameters
  Serial.println();
}

void clearRxBuffer() {
  while (Serial.available() > 0){
    Serial.read();
  }
}
