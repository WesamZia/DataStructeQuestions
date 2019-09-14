using System;
    class PGetRepeatedNumbers
    {
        static void Main(string[] args)
        {
            int[] numbersList = new int[] { 1, 0, 6, 9, 7, 5, 3, 6, 0, 8, 1 };

            int size = numbersList.Length;

            Console.WriteLine("size  = {0}", size);

            GetRepeatedNumbers(numbersList, size);
        }

        static void GetRepeatedNumbers(int[] arr, int size)
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
