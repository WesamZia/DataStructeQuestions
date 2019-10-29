internal static class CommonHelpers
{
    internal static string ReverseString(string txt)
    {

        char[] charArray = txt.ToCharArray();

        for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
        {
            charArray[i] = txt[j];
            charArray[j] = txt[i];

        }

        string revString = new string(charArray);

        return revString;

    }

}