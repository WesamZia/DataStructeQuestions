internal static class SortingHelpers
{

    internal static int[] QuickSort(int[] numbers, int left, int right)
    {
        int size = numbers.Length;
        var _result = new int[size];
        left = 0;
        right = numbers.Length - 1;

        if (left < right)
        {
            int pIndx = Partition(numbers, left, right);

            QuickSort(numbers, left, pIndx - 1);
            QuickSort(numbers, pIndx + 1, right);

        }

        static int Partition(int[] arr, int left, int right)
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

            return i +1;
        }

        return _result;
    }


}