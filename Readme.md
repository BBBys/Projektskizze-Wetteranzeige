# Skizze: Anzeige von Wetterdaten 
## Ziel
- Abfrage von Wetter/Klimadaten
-	-	Aussen: Temperatur, Feuchtigkeit, Wind, Luftdruck von OpenWeatherMap
-	-	Innen: Temperatur, Druck, Feuchtigkeit von einem BME280-Sensor
- Aufbereitung auf einem Raspberry Pico W
- Ausgabe auf einem ePaper-Display
## Vorbereitung
API-Key von OpenWetherMap besorgen: auf https://openweathermap.org/price unter **Free** --> *Get API Key* anmelden. Abfragelimit auf unter 1000 setzen, dann 
fallen keine Kosten an. Im Programm nicht schneller als im Abstand von 90 Sekunden abfragen.

Oder den vorhandenen Key benutzen und nicht häufiger als alle 120 Sekunden abfragen.
## Hardware
### BME280 verbinden
- **VCC** (3.3V) -&gt; VIN des Sensors
- **GND** -&gt; GND des Sensors
- **SDA** (GPIO 2) -&gt; SDA des Sensors
- **SCL** (GPIO 3) -&gt; SCL des Sensors
## Software
- Micro Python
## Quellen
https://www.kampis-elektroecke.de/raspberry-pi/raspberry-pi-wetter/
Anschluss ePaper-Display https://www.az-delivery.de/en/blogs/azdelivery-blog-fur-arduino-und-raspberry-pi/e-paper-display-am-esp32-und-esp8266-teil1
Datenabruf und Auswertung https://microcontrollerslab.com/raspberry-pi-pico-w-openweathermap-api-sensorless-weather-station
BME280-Bibliothek https://learn.microsoft.com/en-us/dotnet/api/iot.device.bmxx80.bme280?view=iot-dotnet-latest
BME280-Anschluss https://learn.microsoft.com/en-us/dotnet/iot/tutorials/temp-sensor?citationMarker=43dcd9a7-70db-4a1f-b0ae-981daa162054
