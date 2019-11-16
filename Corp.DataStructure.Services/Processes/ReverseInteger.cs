using System;


public class PReverseInteger
{
    static public int ReverseInt(int x)
    {
        int orignalNumber = x;
        int lastDigit = 0;
        int reversedNumber = 0;

        while (Convert.ToBoolean(orignalNumber))
        {
            lastDigit = orignalNumber % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            orignalNumber = orignalNumber / 10;

        }

        return reversedNumber;
    }
}
