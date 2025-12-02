using AdventOfCode.PasswordSolver;

namespace AdventOfCode;

class Program
{
    static void Main(string[] args)
    {
        
        string[] inputs = File.ReadAllLines("inputs.txt");

        // Create the logic class
        var logic = new LockLogic(inputs);

        // Run the process
        int result = logic.Process();

        int advancedResult = logic.AdvancedProcess();

        // Output result
        Console.WriteLine($"Final counter: {result}");

        Console.WriteLine($"Advanced counter: {advancedResult}");
    }
}