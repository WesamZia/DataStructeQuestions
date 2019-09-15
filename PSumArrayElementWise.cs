using System;

class PSumArrayElementWise
{
    public static int[] Process(int[] arr1, int[] arr2)
    {
        int sum = 0;
        int len1 = 0;
        int len2 = 0;
        int size = 0;
        int carry = 0;

        if (arr1.Length > arr2.Length) { size = arr1.Length; }
        else { size = arr2.Length; }

        int[] RepArray = new int[size+1];

        for (int i = 0; i < size; i++)
        {
            //output = (val % 2 == 1) ? "Number is odd" : "Number is even";
            sum = ( (len1 - i >= 0) ? arr1[len1 - i] : 0) + ( (len2 - i >= 0) ? arr2[len2 - i] : 0) + carry;

            RepArray[(size - i)] = sum % 10;
            carry = sum / 10;
        }
       // RepArray[0] = carry;
        return RepArray;


    }

}