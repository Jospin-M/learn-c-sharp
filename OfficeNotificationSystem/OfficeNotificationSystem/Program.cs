public enum Priority
{
    Low,     // For routine notifications
    Medium,  // For important notifications
    High,    // For time-sensitive notifications
    Urgent   // For emergency notifications
}

public class NotificationSystem
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Attempting to send: {message}");
    }
}

public class EmailSubscriber
{
    // Will be implemented in later tasks
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Corporate Notification System");
    }
}