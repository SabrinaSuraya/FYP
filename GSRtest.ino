const int GSR=A0;
const int ButtonStop = 8; //stop record data button
int sensorValue=0;
 
void setup(){
  Serial.begin(9600);
}
 
void loop(){
  while(!digitalRead (ButtonStop)){ //hold button to stop record
  sensorValue=analogRead(GSR);
  Serial.println(sensorValue);
  delay(1000);   
  }
}
