using System;
using System.Collections.Generic;

class MainClass
    {
        static void Main(string[] args)
        {

          		// input vectors 
		int[] arr1 = {23, 5, 2, 7, 87}; 
		List<int> a = new List<int>(); 
		foreach(int i in arr1) 
			a.Add(i); 
			
		int[] arr2 = {4, 67, 2, 8}; 
		List<int> b = new List<int>(); 
		foreach(int i in arr2) 
			b.Add(i); 

		//PSumArrayElementWise.add(a, b); 




            int[] numbersList = new int[] { 1, 0, 6, 9, 7, 5, 3, 6, 0, 8, 1 };

            int size = numbersList.Length;

            Console.WriteLine("size  = {0}", size);

                 int[] arr12 = new int[] {1,2,3};
                 int[] arr22 = new int[] {1,2};

            //PSumArrayElementWise.Process(arr1,arr2);

          //  GetRepeatedNumbers(numbersList, size);
        }
    }
