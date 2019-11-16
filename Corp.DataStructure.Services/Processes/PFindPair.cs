using System;
using System.Collections.Generic;

public class PFindPair
{
    public void process(int[] numbersList,int sum)
    {
        // find pairs that sums up to n
        var randomNumbers = new int[] { 1, 9, 7, 11, 4, 8, 5, 2, 22, 3, 4, 6, 10 };
        int left = 0;
        int right = randomNumbers.Length - 1;
        sum = 13;

        quickSort(randomNumbers, left, right);

        foreach (int item in randomNumbers)
        {
            Console.WriteLine("Sorted Array {0}", item);
        }

        findPair(randomNumbers, sum);

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
        int pivot = arr[right];
        int i = left - 1;


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
    static public void findPair(int[] randomNumbers, int sum)
    {
        int low = 0;
        int high = randomNumbers.Length - 1;

        List<String> listOfPairs = new List<String>();

        while (low < high)
        {
            if (randomNumbers[low] + randomNumbers[high] == sum)
            {

                Console.WriteLine("the pair of {0} and {1} sum up to {2}", randomNumbers[low], randomNumbers[high], sum);
                low++;
                high--;
            }
            else if (randomNumbers[low] + randomNumbers[high] < sum)
            {
                low++;
            }
            else
            {
                high--;
            }
        }

        foreach (string item in listOfPairs)
        {
            Console.Write("sum of  {0} -", item);
        }

    }
}
