using System;
using System.Collections.Generic;

public class PFindPrimeNumbers
{
    public void Process(int[] numbersList)
    {

        List<int> numList = new List<int>();

        foreach (int item in numbersList)
        {
            for (int x = 1; x <= item; x++)
            {
                if (item % x == 0)
                {
                    numList.Add(x);
                }
            }
            if (numList.Count == 2)
            {
                Console.WriteLine(item + " is a prime number ");
            }
            else
            {
                Console.WriteLine(item + " is not a prime number ");
            }
            numList = new List<int>();
        }
    }
}