public class PRemoveNfromArray
{
    // return array length without value n
    public int Process(int[] randomNums, int targetValue)
    {
        int filteredArraySize = 0;

        for (int i = 0; i < randomNums.Length; i++)
        {
            if (randomNums[i] == targetValue)
            {
                randomNums[filteredArraySize] = randomNums[i];
                filteredArraySize++;
            }
        }
        return filteredArraySize;
    }
}