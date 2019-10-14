// find number of missing elements in a given array 
using System;
using System.Collections.Generic;

public class PFindMissingElements
{
    public int Process(int[] numbersList)
    {
        Array.Sort(numbersList);

        HashSet<int> set = new HashSet<int>();

        for (int i = numbersList[0]; i < numbersList[numbersList.Length - 1]; i++)
        {
            set.Add(i);
        }

        for (int i = 0; i < numbersList.Length; i++)
        {
            set.Remove(numbersList[i]);
        }

        var x = set.Count;

        return x;
    }
}