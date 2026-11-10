namespace SmartTemperatureSensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SensorReading reading = new SensorReading();
            reading.Update(100m);

            Console.WriteLine($"Value: {reading.Value}\nLastUpdated: {reading.LastUpdated}");

            reading.Update(null);

            Console.WriteLine($"Value: {reading.Value}\nLastUpdated: {reading.LastUpdated}");

            TemperatureSensor sensor = new TemperatureSensor { Temperature = reading };
            
            Console.WriteLine(sensor.ValidateReading());

            Schedule schedule = new Schedule();

            Console.WriteLine(schedule.GetCurrentTarget(true));

            schedule.DayTarget = 96m;

            Console.WriteLine(schedule.GetCurrentTarget(true));

            SensorReading nullReading = new SensorReading();
            
            Console.WriteLine(nullReading.GetStatusSummary());

            nullReading.Update(100m);

            Console.WriteLine(nullReading.GetStatusSummary());
        }
    }
}