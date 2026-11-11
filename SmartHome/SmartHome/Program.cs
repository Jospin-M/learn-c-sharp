using System;

namespace SmartHome
{
    // Pre-implemented sensor simulation
    public class Sensors
    {
        private static Random _random = new Random();

        public static double GetTemperature(string sensorId)
        {
            // Simulates temperature between 65-80 degrees
            return 65 + _random.NextDouble() * 15;
        }

        public static double GetHumidity(string sensorId)
        {
            // Simulates humidity between 30-60%
            return 30 + _random.NextDouble() * 30;
        }

        public static double GetMotion(string sensorId)
        {
            // Simulates motion detection (0-1 scale)
            return _random.NextDouble();
        }
    }

    public class HomeAutomation
    {
        // Basic Sensor System: Delegates will be declared here
        public delegate double SensorProcessor(string reading);

        public void ProcessSensorData(string[] sensors, SensorProcessor processor)
        {
            // Task: Implement sensor processing using delegates
            foreach(string sensor in sensors)
            {
                Console.WriteLine(processor(sensor));
            }
        }

        // Built-in Delegates: Built-in delegates will be defined here

        // Instance Methods and Predicates: Temperature control for method group conversion
        public class TemperatureControl
        {
            public Predicate<double>? IsComfortable { get; set; }
        }

        // Multicast Delegates: Fields for multicast example
        private double _currentTemp = 72.0;
        private bool _lightsOn = false;

        public void AdjustHVAC(string device, string action)
        {
            _currentTemp += action == "up" ? 1 : -1;
            Console.WriteLine($"Temperature now: {_currentTemp}");
        }

        public void ControlLights(string device, string action)
        {
            _lightsOn = action == "on";
            Console.WriteLine($"Lights are now {(_lightsOn ? "on" : "off")}");
        }

        // Complex Automation Rules: Base class for automation rules
        public class AutomationRule
        {
            // Task: Implement rule properties
            public Predicate<double>? Condition { get; set; } 
            public Action<string, string>? Actions { get; set; }
            public string? Device { get; set; }
            public string? Action { get; set; }
        }

        public void ProcessRule(AutomationRule rule, double sensorReading)
        {
            // Task: Implement rule processing
            rule?.Actions(rule.Action, rule.Device);
        }

        public static void Main()
        {
            var home = new HomeAutomation();
            Console.WriteLine("Smart Home Automation Starting...");

            // Test code will be added for each task group
            string[] tempSensors = { "TEMP1", "TEMP2" };
            SensorProcessor processor = Sensors.GetTemperature;
            HomeAutomation homeAutomation = new HomeAutomation();
            homeAutomation.ProcessSensorData(tempSensors, processor);

            Func<double, bool> isValidReading = num => num is >= 0 and <= 100;
            Console.WriteLine(isValidReading(21));

            Action<string, double> logReading = (string sensorId, double reading) => Console.WriteLine($"{sensorId}: {reading}");
            logReading("ABC", 1738);

            Predicate<double> isCritical = reading => reading > 90;
            Console.WriteLine(isCritical(90.000000001));

            TemperatureControl control = new TemperatureControl { IsComfortable = temp => temp is >= 68 and <= 76 };
            Console.WriteLine(control.IsComfortable(68));

            double[] comfortableTemps = Array.FindAll([65.0, 70.0, 75.0, 80.0], control.IsComfortable);

            foreach(double temp in comfortableTemps)
            {
                Console.WriteLine(temp);
            }

            Action<string, string> AutomationHandler = homeAutomation.AdjustHVAC;
            AutomationHandler += homeAutomation.ControlLights;
            AutomationHandler("MAIN", "on");

            AutomationRule rule = new AutomationRule
            {
                Condition = temp => temp < 68,
                Actions = AutomationHandler,
                Action = "on",
                Device = "MAIN"
            };
        }
    }
}