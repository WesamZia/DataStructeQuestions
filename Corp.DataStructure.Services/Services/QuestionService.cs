using System.Collections.Generic;
public class QuestionService : IQuestionService
{
    public bool IsPalindrome(string text)
    {
       PIsPalindrome _service = new PIsPalindrome();
       return _service.Process(text);
    }
    public void FindPair(int[] numbersList,int sum)
    {
        PFindPair _service = new PFindPair();

        _service.process(numbersList,sum);

    }
    public void GetRepeatedNumbers(int[] arr, int size)
    {
        PGetRepeatedNumbers _service = new PGetRepeatedNumbers();

        _service.process( arr, size);
    }
    public void SumArrayElementWise(List<int> a, List<int> b)
    {
        PSumArrayElementWise _service = new PSumArrayElementWise();

        _service.add(a,b);
    }

}