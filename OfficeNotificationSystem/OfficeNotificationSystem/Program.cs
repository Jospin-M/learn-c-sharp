public enum Priority
{
    Low,     // For routine notifications
    Medium,  // For important notifications
    High,    // For time-sensitive notifications
    Urgent   // For emergency notifications
}

public class NotificationSystem
{
    public event EventHandler<NotificationEventArgs> Notification;

    protected virtual void OnNotification(string dept, string msg, Priority priority)
    {
        Notification?.Invoke(this, new NotificationEventArgs(dept, msg, priority));
    }

    public void SendNotification(string dept, string message, Priority priority)
    {
        Console.WriteLine($"Attempting to send: {message}");
        
        if(Notification != null)
        {
            OnNotification(dept, message, priority);
        }
    }
}

public class NotificationEventArgs : EventArgs { 
    public string Department { get; set; }
    public string Message { get; set; }
    public Priority Priority { get; set; }

    public NotificationEventArgs(string department, string message, Priority priority)
    {
        Department = department;
        Message = message;
        Priority = priority;
    }
}

public class EmailSubscriber
{
    // Will be implemented in later tasks
    public void HandleDetailedNotification(object sender, NotificationEventArgs e)
    {
        Console.WriteLine("Email: Notification received");
        Console.WriteLine($"Department: {e.Department}\nPriority: {e.Priority}\nMessage: {e.Message}");
    }
}

public interface INotificationPublisher 
{
    public event EventHandler<NotificationEventArgs> DetailedNotification;
}

public class UrgentNotificationSystem : INotificationPublisher
{
    public event EventHandler<NotificationEventArgs> DetailedNotification;

    protected virtual void OnUrgentNotification(string dept, string msg)
    {
        DetailedNotification?.Invoke(this, new NotificationEventArgs(dept, msg, Priority.Urgent));
    }

    public void SendUrgentNotification(string dept, string msg)
    {
        Console.WriteLine("Urgent notification is being sent!");
        OnUrgentNotification(dept, msg);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Corporate Notification System");

        NotificationSystem notifier = new NotificationSystem();
        EmailSubscriber subscriber = new EmailSubscriber();

        notifier.Notification += subscriber.HandleDetailedNotification;
        notifier.SendNotification("IT","System needs update", Priority.High);

        UrgentNotificationSystem urgentNotifier = new UrgentNotificationSystem();
        urgentNotifier.DetailedNotification += subscriber.HandleDetailedNotification;
        urgentNotifier.SendUrgentNotification("IT", "System needs an update.");
    }
}