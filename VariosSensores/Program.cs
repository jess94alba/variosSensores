using System;
using System.Collections.Generic;
using System.Linq;

public class SensorTemperatura
{
    public string Nombre { get; set; }
    public List<double> Lecturas { get; set; }

    public SensorTemperatura(string nombre)
    {
        Nombre = nombre;
        Lecturas = new List<double>();
    }

    public double ObtenerPromedio()
    {
        return Lecturas.Average();
    }
}

public class Program
{
    public static void Main()
    {
        List<SensorTemperatura> sensores = new List<SensorTemperatura>
        {
            new SensorTemperatura("Sensor 1") { Lecturas = new List<double> { 22.5, 23.0, 21.8 } },
            new SensorTemperatura("Sensor 2") { Lecturas = new List<double> { 19.5, 20.0, 20.5 } },
            new SensorTemperatura("Sensor 3") { Lecturas = new List<double> { 25.0, 24.5, 24.8 } }
        };

        foreach (var sensor in sensores)
        {
            Console.WriteLine($"Promedio de {sensor.Nombre}: {sensor.ObtenerPromedio():F2}°C");
        }
    }
}