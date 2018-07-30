using System;

namespace StairCaseNumberOfBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Start: 

            Console.WriteLine("Enter Number of blocks: ");
            var blocks = Console.ReadLine();          

            var result = CalculateMaxStairCaseHeigtFromBlocks(int.Parse(blocks));

            Console.WriteLine("Maximum height of stair case made using {0} blocks is {1}", blocks, result);

            goto Start;

            Console.ReadLine();
        }

        public static int CalculateMaxStairCaseHeigtFromBlocks(int blocks)
        {
            // Base case. 
            if (blocks < 3)
            {
                return 1;
            }

            int blocksTotal = 0;

            for (int stairs = 0; stairs < blocks; stairs++)
            {
                blocksTotal += stairs;

                if (blocksTotal <= blocks && (blocks < blocksTotal + (stairs + 1)))
                {
                    return stairs;
                }
            }

            return 0;
        }
    }
}
