from waveshare_epaper import epaper
import machine

# EPaper Display einrichten
epaper = epaper.EPD()
epaper.begin()

# Daten auf dem Display anzeigen
epaper.clear()
epaper.drawText('Temperatur: ' + str(data['main']['temp']))
epaper.drawText('Luftfeuchtigkeit: ' + str(data['main']['humidity']))
epaper.display()