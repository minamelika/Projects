using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars, numOfDays;
            float rntPerDay, totalAmt;
            Console.WriteLine("Kindly enter the car rent per day");
            rntPerDay = float.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter number of cars rented");
            numOfCars = int.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter number of rent days");
            numOfDays = int.Parse(Console.ReadLine());
            totalAmt = rntPerDay * numOfCars * numOfDays;
            Console.WriteLine("Total rent amount is : {0}", Math.Round(totalAmt, 2));
            Console.ReadLine();

        }
    }
}
