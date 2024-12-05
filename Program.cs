using System;
using System.Collections.Generic;

namespace MyApp
{
    // Define the TemperatureMeasurement class
    public class TemperatureMeasurement
    {
        public double Temperature { get; set; }
        public DateTime Time { get; set; }

        public TemperatureMeasurement(double temperature, DateTime time)
        {
            Temperature = temperature;
            Time = time;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of TemperatureMeasurement objects
            List<TemperatureMeasurement> measurements = new List<TemperatureMeasurement>
            {
                new TemperatureMeasurement(53.4, new DateTime(2024, 12, 1, 8, 0, 0)),  
                new TemperatureMeasurement(92.1, new DateTime(2024, 12, 1, 12, 0, 0)),
                new TemperatureMeasurement(68.3, new DateTime(2024, 12, 1, 16, 0, 0)),
                new TemperatureMeasurement(48.7, new DateTime(2024, 12, 1, 20, 0, 0)),
                new TemperatureMeasurement(32.5, new DateTime(2024, 12, 2, 0, 0, 0))
            };

            const double temperatureCutOff = 50.0;
            double sumTemperatures = 0.0;
            int numberOfMeasurementsAboveCutOff = 0;

            // Process the list
            foreach (var measurement in measurements)
            {
                if (measurement.Temperature > temperatureCutOff)
                {
                    sumTemperatures += measurement.Temperature;
                    numberOfMeasurementsAboveCutOff++;
                }
            }

            // Calculate the average temperature above the cutoff
            double averageTemperature = numberOfMeasurementsAboveCutOff > 0
                ? sumTemperatures / numberOfMeasurementsAboveCutOff
                : 0.0;

            Console.WriteLine("Average temperature of measurements > " + temperatureCutOff +
                              "°F was: " + averageTemperature + "°F");
        }
    }
}