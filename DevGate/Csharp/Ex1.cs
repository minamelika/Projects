using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float tmp1, tmp2, tmp3, tmp4, tmp5, avg;
            Console.WriteLine("Kindly enter the 1st area temprature");
            tmp1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter the 2nd area temprature");
            tmp2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter the 3rd area temprature");
            tmp3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter the 4th area temprature");
            tmp4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Kindly enter the 5th area temprature");
            tmp5 = float.Parse(Console.ReadLine());
            avg = (tmp1 + tmp2 + tmp3 + tmp4 + tmp5) / 5;
            Console.WriteLine("Avg Temp is : {0}", avg);
            Console.ReadLine();

        }
    }
}
