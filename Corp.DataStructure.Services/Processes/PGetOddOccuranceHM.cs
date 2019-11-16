using System.Collections.Generic;

public class PGetOddOccuranceHM
{
    public int Process(int[] numbersList)
    {
        int arraySize = numbersList.Length;
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        for (int i = 0; i < arraySize; i++)
        {
            if (hashMap.ContainsKey(numbersList[i]))
            {
                int numberOfOccurrences = hashMap[numbersList[i]];//value of key i // score of occurrences thus far for i integer
                hashMap[numbersList[i]]++; // +1 to value of key[numbersList[i]]

                // alternative way of adding score to excisting keys
                //hashMap.Remove(numbersList[i]); // remove the key before adding the same key with the new score (Hashmaps don't allow duplication)
                //hashMap.Add(numbersList[i], numberOfOccurrences + 1);
            }
            else
            {
                hashMap.Add(numbersList[i], 1);
            }
        }
        foreach (KeyValuePair<int, int> item in hashMap)
        {
            if (item.Value % 2 != 0) { return item.Key; }
        }
        return 0;
    }
}