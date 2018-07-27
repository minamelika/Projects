using System;

namespace Ex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flNo;
            float monthCost;
            Console.WriteLine("Kindly enter the floor number");
            flNo = int.Parse(Console.ReadLine());
            switch (flNo)
            {
                case 0:
                case 1:
                    {
                        monthCost = 7000;
                        break;
                    }
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        monthCost = 5150;
                        break;
                    }
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    {
                        monthCost = 3570;
                        break;
                    }
                default:
                    {
                        monthCost = 0;
                        break;
                    }
            }
            Console.WriteLine("Monthly cost is : {0}", monthCost);
            Console.ReadLine();
        }
    }
}
