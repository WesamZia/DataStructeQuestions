using System.Text;

public class PReverseWordOrder 
{

    public string Process(string text)
    {

        string[] textArray = text.Split(' ');
        string revText = "";

        for (int i = textArray.Length -1; i >= 0; i--)
        {
            revText += textArray[i] + " ";
        }

        return revText;
    }

}