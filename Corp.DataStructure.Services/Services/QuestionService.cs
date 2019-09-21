public class QuestionService : IQuestionService
{
    public bool IsPalindrome(string text)
    {
       PIsPalindrome _service = new PIsPalindrome();
       return _service.Process(text);
    }
    
}