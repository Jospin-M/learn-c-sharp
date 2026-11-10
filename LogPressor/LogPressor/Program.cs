using System;
using System.Collections.Generic;
using LogPressor;

namespace LogProcessor
{

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
            int processedCount = 0;

            foreach (string entry in logEntries)
            {
                totalCount++;

                ProcessLogEntry(entry, ref processedCount);
            }

            Console.WriteLine($"Processed {processedCount} out of {totalCount} entries");
        }

        private static void ProcessLogEntry(string entry, ref int processedCount)
        {
            if (entry == null || entry == "")
            {
                throw new InvalidLogFormatException("Empty or null log entry");
            }

            try
            {
                string[] parts = entry.Split('|');

                if(parts.Length != 3)
                {
                    throw new InvalidLogFormatException("Invalid format. Expected: timestamp|level|message");
                }

                if(parts[1] != "ERROR" && parts[1] != "WARN" && parts[1] != "INFO")
                {
                    throw new InvalidLogFormatException($"Invalid log level: {parts[1]}. Expected: ERROR, WARN, or INFO");
                }

                string level = parts[1].Trim().ToUpper();
                processedCount++;

                // Process valid entry
                Console.WriteLine($"Log Entry - Time: {parts[0].Trim()}, Level: {level}, Message: {parts[2].Trim()}");
            }
            catch (InvalidLogFormatException ex) when (entry.Contains('|')) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidLogFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing entry: {ex.Message}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Test null list handling
            Console.WriteLine("Testing null list handling");

            try
            {
                LogProcessor nullProcessor = new LogProcessor(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Null list error: {ex.Message}");
            }

            Console.WriteLine();

            // Test malformed entry handling
            Console.WriteLine("Testing malformed entry");
            
            try
            {
                List<string> malformedLogs = new List<string>
                {
                    "",
                    "2024-01-15 10:30:00|INFO|Application started",
                    "bad format",
                    "2024-01-15 10:31:00|WARN|Low memory warning"
                };
                LogProcessor p = new LogProcessor(malformedLogs);
                p.ProcessLogs();
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing entry: {ex.Message}");
            }

            Console.WriteLine();

            // Test log level validation
            Console.WriteLine("Testing invalid log levels");
            List<string> invalidLevelLogs = new List<string>
            {
                "2024-01-15 10:30:00|DEBUG|This should not work",
                "2024-01-15 10:30:00|INFO|Application started",
                "2024-01-15 10:30:00|CRITICAL|This also should not work"
            };
            LogProcessor processor = new LogProcessor(invalidLevelLogs);
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
}