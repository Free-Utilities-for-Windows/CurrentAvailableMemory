using System.Diagnostics;

class Program
{
    static void Main()
    {
        var pc = new PerformanceCounter("Memory", "Available MBytes");
        var availableMemoryInMB = pc.NextValue();
        var availableMemoryInGB = availableMemoryInMB / 1024;

        Console.WriteLine($"Available memory: {availableMemoryInGB} GB");

        if (availableMemoryInGB < 3)
        {
            Console.WriteLine("Less than 3GB memory available. Please close unnecessary applications or services.");

            Process[] processlist = Process.GetProcesses();

            Console.WriteLine("Here are the running processes:");
            foreach (Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }

            Console.Write("Enter the ID of the process you want to stop: ");
            int processId = Convert.ToInt32(Console.ReadLine());

            try
            {
                Process process = Process.GetProcessById(processId);
                process.Kill();
                Console.WriteLine($"Process {processId} has been stopped.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Process {processId} does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Sufficient memory available.");
        }
    }
}