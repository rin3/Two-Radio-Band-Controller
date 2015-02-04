
/*
	Sketch title
 
 	Describe what it does in layman's terms.  Refer to the components
 	attached to the various pins.
 
 	The circuit:
 	* list the components attached to each input
 	* list the components attached to each output
 
 	Created day month year
 	By author's name
 	Modified day month year
 	By author's name
 
 	http://url/of/online/tutorial.cc
 
 */


const int pinRx[] = {
  0, 19, 17, 15};
const int pinTx[] = {
  1, 18, 16, 14};

byte bRX;  // received byte

void setup() {
  // turn L(13) off
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  
  // initialize serial
//  Serial3.begin(9600);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    bRX = Serial.read();
    Serial.println(bRX, HEX); 
  }
}


