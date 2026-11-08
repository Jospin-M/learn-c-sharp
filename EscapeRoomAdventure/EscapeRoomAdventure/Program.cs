using EscapeRoomAdventure;
using File = EscapeRoomAdventure.File;

internal class Program
{
    static void Main(string[] args)
    {
        FieldAgent agent1 = new FieldAgent("Agent Smith", 007);
        FieldAgent agent2 = agent1;
        agent2.SecretCode = 999;

        Console.WriteLine($"{agent1.SecretCode} {agent2.SecretCode}");

        File file1 = new File("Confidential.txt", 1024);
        File file2 = new File("Confidential.txt", 1024);

        bool sameFile = file1 == file2;

        Console.WriteLine(sameFile);

        Server mainServer = new Server();
        Server backupServer = new Server();

        mainServer.Status = "Active";
        backupServer.Status = "Inactive";

        ISystem[] systems = new ISystem[] { mainServer, backupServer };

        foreach(ISystem system in systems)
        {
            system.Operate();
        }
    }
}