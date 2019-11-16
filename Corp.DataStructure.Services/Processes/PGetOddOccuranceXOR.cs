public class PGetOddOccuranceXOR
{
    public int Process (int [] numbersArray)
    {
        int result = 0;
        int arraySize = numbersArray.Length;

        for(int i = 0; i < arraySize;i++)
        {
            result ^= numbersArray[i];
        }

        return result;
    }

}