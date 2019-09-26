using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract()]
public interface IQuestionService
{

    [OperationContract]
    void FindPair(int[] numbersList, int sum);
    [OperationContract]
    bool IsPalindrome(string text);
    [OperationContract]
    public void GetRepeatedNumbers(int[] arr, int size);

    [OperationContract]
    public void SumArrayElementWise(List<int> a, List<int> b);

}