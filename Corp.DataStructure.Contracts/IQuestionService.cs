    using System.ServiceModel;

    [ServiceContract()]
    public interface IQuestionService
    {
       [OperationContract]
       bool IsPalindrome(string text);  

    }