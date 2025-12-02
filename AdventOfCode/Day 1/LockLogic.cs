namespace AdventOfCode.PasswordSolver;

public class LockLogic
{

    private readonly string[] inputs;

    public LockLogic(string[] inputs)
    {
        this.inputs = inputs;
    }


    public int Process()
    {
        //Starting point
        int total = 50;
        int counter = 0;

        //For each loop that loops through each prompt
        foreach (var input in inputs)
        {
            //direction
            var inputDir = input[0];

            // amount = everything after the first character, parsed to int
            int inputAmount = int.Parse(input.Substring(1));

            if (inputDir == 'R')
            {
                total += inputAmount;
            }
            else if (inputDir == 'L')
            {
                total -= inputAmount;
            }
            
            //  Keep total in range 0–99
            total = ((total % 100) + 100) % 100;
            
            if (total == 0)
            {
                counter++;
            }
        }
        
        return counter;
    }

    
    public int AdvancedProcess()
    {
        //Starting point
        int total = 50;
        int counter = 0;

        //For each loop that loops through each prompt
        foreach (var input in inputs)
        {
            //direction
            var inputDir = input[0];

            // amount = everything after the first character, parsed to int
            int inputAmount = int.Parse(input.Substring(1));

            int step = inputDir == 'R' ? 1 : inputDir == 'L' ? -1 : 0;

            for (int i = 0; i < inputAmount; i++)
            {
                //  Keep total in range 0–99
                total = (total + step + 100) % 100; // wrap 0..99
                if (total == 0) counter++;
            }
            
        }
        
        return counter;
    }
    
}