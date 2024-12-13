using System;
using System.Device.I2c;
using Iot.Device.Bmxx80;
using Iot.Device.Bmxx80.PowerMode;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var i2cSettings = new I2cConnectionSettings(1, Bme280.DefaultI2cAddress);
        using var i2cBus = I2cDevice.Create(i2cSettings);
        using var bme280 = await Bme280.CreateAsync(i2cBus);

        bme280.SetTemperatureSampling(Sampling.UltraHighResolution);
        bme280.SetPressureSampling(Sampling.UltraHighResolution);
        bme280.SetHumiditySampling(Sampling.UltraHighResolution);

        while (true)
        {
            await Task.Delay(1000);
            var temperature = bme280.ReadTemperatureCelsius();
            var humidity = bme280.ReadHumidity();
            var pressure = bme280.ReadPressure();

            Console.WriteLine($"Temperatur: {temperature} °C");
            Console.WriteLine($"Luftfeuchtigkeit: {humidity}%");
            Console.WriteLine($"Luftdruck: {pressure} hPa");
        }
    }
}