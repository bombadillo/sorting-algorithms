namespace SortingAlgorithms.Interfaces
{
    using System.Collections.Generic;
    
    public interface IQuickSort
    {
        int Iterations { get; set; }
        List<int> Sort(List<int> originalList, int leftPointer = 0, int rightPointer = 0);
    }
}
