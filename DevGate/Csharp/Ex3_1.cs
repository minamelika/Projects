using System;

namespace Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int flNo;
            float monthCost;
            Console.WriteLine("Kindly enter the floor number");
            flNo = int.Parse(Console.ReadLine());
            if (flNo == 0 || flNo == 1)
            {
                monthCost = 7000;
            }
            else if (flNo > 1 && flNo <= 5)
            {
                monthCost = 5150;
            }
            else if (flNo >= 6 && flNo <= 10)
            {
                monthCost = 3570;
            }
            else
            {
                monthCost = 0;
                Console.WriteLine("Out of range");
            }
            Console.WriteLine("Monthly cost is : {0}", monthCost);
           Console.ReadLine();
        }
    }
}
