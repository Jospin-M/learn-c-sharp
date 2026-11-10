using System;
using System.Collections.Generic;


public class LogProcessor
{
    private readonly List<string> logEntries;

    public LogProcessor(List<string> logEntries)
    {
        this.logEntries = logEntries ?? throw new ArgumentNullException(nameof(logEntries));
    }

    public void ProcessLogs()
    {
        int totalCount = 0;
        foreach (string entry in logEntries)
        {
            totalCount++;

            ProcessLogEntry(entry);
        }
    }

    private void ProcessLogEntry(string entry)
    {
        string[] parts = entry.Split('|');
        string level = parts[1].Trim().ToUpper();

        // Process valid entry
        Console.WriteLine($"Log Entry - Time: {parts[0].Trim()}, Level: {level}, Message: {parts[2].Trim()}");
    }
}

class Program
{
    static void Main()
    {
        // Test null list handling
        Console.WriteLine("Testing null list handling");
        LogProcessor nullProcessor = new LogProcessor(null);
        Console.WriteLine();

        // Test malformed entry handling
        Console.WriteLine("Testing malformed entry");
        List<string> malformedLogs = new List<string>
    {
      "",
      "2024-01-15 10:30:00|INFO|Application started",
      "bad format",
      "2024-01-15 10:31:00|WARN|Low memory warning"
    };
        LogProcessor processor = new LogProcessor(malformedLogs);
        processor.ProcessLogs();
        Console.WriteLine();

        // Test log level validation
        Console.WriteLine("Testing invalid log levels");
        List<string> invalidLevelLogs = new List<string>
    {
      "2024-01-15 10:30:00|DEBUG|This should not work",
      "2024-01-15 10:30:00|INFO|Application started",
      "2024-01-15 10:30:00|CRITICAL|This also should not work"
    };
        processor = new LogProcessor(invalidLevelLogs);
        processor.ProcessLogs();
        Console.WriteLine();

        // Test valid log processing
        Console.WriteLine("Testing valid logs");
        List<string> validLogs = new List<string>
    {
      "2024-01-15 10:30:00|INFO|Application started",
      "2024-01-15 10:31:00|WARN|Low memory warning",
      "2024-01-15 10:32:00|ERROR|Process crashed"
    };
        processor = new LogProcessor(validLogs);
        processor.ProcessLogs();
    }
}