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
    void GetRepeatedNumbers(int[] arr, int size);
    [OperationContract]
    void SumArrayElementWise(List<int> a, List<int> b);
    [OperationContract]
    int ConsecutiveArray(int[] numbers);
    [OperationContract]
    int FindMissingElements(int[] numbers);

}