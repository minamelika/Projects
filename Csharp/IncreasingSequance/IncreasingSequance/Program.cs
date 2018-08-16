using System;

namespace IncreasingSequance
{
    class Program
    {
        static bool almostIncreasingSequence(int[] sequence)
        {
            bool isSequence = true;
            int noOfElmnt = 0;
            Array.Sort(sequence);
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    continue;
                }
                else
                    noOfElmnt++;
            }
            if (noOfElmnt > 1)
                isSequence = false;

            return isSequence;
        }

        static void Main(string[] args)
        {
            int[] seq = { 1, 4, 10, 4, 2 };
            Console.WriteLine(almostIncreasingSequence(seq));
        }
    }
}
