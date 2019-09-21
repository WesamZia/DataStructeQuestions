using System;
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] numbersList = new int[] { 1, 0, 6, 9, 7, 5, 3, 6, 0, 8, 1 };

            int size = numbersList.Length;

            Console.WriteLine("size  = {0}", size);

                 int[] arr1 = new int[] {1,2,3};
                 int[] arr2 = new int[] {1,2};

            PSumArrayElementWise.Process(arr1,arr2);

          //  GetRepeatedNumbers(numbersList, size);
        }
    }
