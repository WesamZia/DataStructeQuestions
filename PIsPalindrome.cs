public class PIsPalindrome
{
    public static bool Process(string text)
    {
        string firstPart = text.Substring(0, text.Length / 2);
        char[] arr = text.ToCharArray();

        //reverse the charecter set
        for (int i = 0; i < firstPart.Length; i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }

        // take the other part of the now reversed text and compare it 
        string temp2 = new string(arr);
        string secoundPart = temp2.Substring(0, arr.Length / 2);

        if (firstPart.Equals(secoundPart))
        {
            return true;
        }
        else
        {
            return false;

        }
    }
}