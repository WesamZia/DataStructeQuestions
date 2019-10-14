
using System;
using System.Linq;

public class PConsecutiveArray
{

    //return number of missing int in a  given list of int
    public int Process(int[] statues)
    {
        if (statues.Length == 1) { return 0; }

        int left = 0;
        int right = statues.Length - 1;
        int numOfMissing = 0;

        quickSort(statues, left, right);

        foreach (int item in statues)
        {
            Console.Write(item);
        }

        var result = Enumerable.Range(statues[0], statues[statues.Length -1]).Except(statues);

        var x = result.Count();

        int j = 0;
        //array is sorted so its sure to have the highest number at end
        for (int i = 0; i < statues.Length; i++)
        {
            if ((statues[j]) + 1 != statues[j + 1])
            {
                numOfMissing++;

            }
            j++;
        }

        return numOfMissing;
    }

    static public void quickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {

            int pi = partition(arr, left, right);

            quickSort(arr, left, pi - 1);
            quickSort(arr, pi + 1, right);
        }

    }

    static public int partition(int[] arr, int left, int right)
    {
        int i = (left - 1);
        int pivot = arr[right];

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp1;

        return i + 1;

    }

}
