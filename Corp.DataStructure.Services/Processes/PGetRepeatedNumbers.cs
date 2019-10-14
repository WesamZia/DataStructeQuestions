using System;

public class PGetRepeatedNumbers
{
    public void process(int[] arr, int size)
    {
        int i;
        int[] count = new int[size];

        Console.WriteLine("the repeated numbers are :");


        for (i = 0; i < size; i++)
        {
            if (count[arr[i]] == 1)
            {
                Console.Write("{0} /", arr[i]);
            }
            else
            {
                count[arr[i]]++;
            }
        }

    }

}

