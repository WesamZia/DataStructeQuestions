using System;
using System.Collections.Generic;

public class PSumArrayElementWise
{

    static void printVector(List<int> result) 
	{ 
		foreach (int i in result) 
		{ 
			Console.Write(i + " "); 
		} 
	} 

	static void split_number(int num, List<int> result) 
	{ 
		if (num > 0) 
		{ 
			split_number(num / 10, result); 
			result.Add(num % 10); 
		} 
	} 


	public void add(List<int> a, List<int> b) 
	{ 

		List<int> result = new List<int>(); 
		int m = a.Count, n = b.Count; 

		int i = 0; 
		while (i < m && i < n) 
		{ 


			int sum = a[i] + b[i]; 

			split_number(sum, result); 
			i++; 
		} 

		while (i < m) 
		{ 
			split_number(a[i++], result); 
		} 

		// Process remaining elements 
		// of second vector, if any 
		while (i < n) 
		{ 
			split_number(b[i++], result); 
		} 

		// Print the resultant vector 
		printVector(result); 
	} 







    // public static int[] Process(int[] arr1, int[] arr2)
    // {

    //     int sum = 0;
    //     int len1 = 0;
    //     int len2 = 0;
    //     int size = 0;
    //     int carry = 0;

    //     if (arr1.Length > arr2.Length) { size = arr1.Length; }
    //     else { size = arr2.Length; }

    //     int[] RepArray = new int[size + 1];

    //     for (int i = 0; i < size; i++)
    //     {
    //         //output = (val % 2 == 1) ? "Number is odd" : "Number is even";
    //         sum = ((len1 - i >= 0) ? arr1[len1 - i] : 0) + ((len2 - i >= 0) ? arr2[len2 - i] : 0) + carry;

    //         RepArray[(size - i)] = sum % 10;
    //         carry = sum / 10;
    //     }
    //     // RepArray[0] = carry;
    //     return RepArray;


    // }

}