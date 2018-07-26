//Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

//Example
//For inputArray = [3, 6, -2, -5, 7, 3], the output should be
//adjacentElementsProduct(inputArray) = 21.
//7 and 3 produce the largest product.

using System;

namespace adjacentElementsProduct
{
    class Program
    {

        static int adjacentElementsProduct(int[] inputArray)
        {
            int rslt = 0;
            int prdct = inputArray[0] * inputArray[1];

            for (int i = 2; i < inputArray.Length; i++)
            {
                rslt = inputArray[i] * inputArray[i - 1];
                if (rslt >= prdct)
                    prdct = rslt;

            }
            return prdct;
        }

        static void Main(string[] args)
        {
            int[] inputArray = { 5, 1, 2, 3, 1, 4 };
            Console.WriteLine(adjacentElementsProduct(inputArray));
            Console.ReadLine();



        }
    }
}
