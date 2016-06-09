namespace SortingAlgorithms.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    
    public class QuickSorter : IQuickSort {

        public int Iterations { get; set; }

        public List<int> Sort(List<int> items, int leftIndex = 0, int rightIndex = 0) {

            if (rightIndex == 0) 
                rightIndex = items.Count - 1;
        
            var index = Partition(items, leftIndex, rightIndex);
        
            if (leftIndex < index - 1) {
              Sort(items, leftIndex, index - 1);
            }
        
            if (index < rightIndex) {
              Sort(items, index, rightIndex);
            }            

            return items;
        }
        
        private int Partition(List<int> items, int leftPointer, int rightPointer) {
            
            var pivot   = items[(rightPointer + leftPointer) / 2];
                
            while (leftPointer <= rightPointer) {
        
                while (items[leftPointer] < pivot) {
                    leftPointer++;
                    Iterations++;
                }
        
                while (items[rightPointer] > pivot) {
                    rightPointer--;
                    Iterations++;
                }
        
                if (leftPointer <= rightPointer) {
                    Swap(items, leftPointer, rightPointer);
                    leftPointer++;
                    rightPointer--;
                    Iterations++;
                }

                Iterations++;
            }
        
            return leftPointer;
        }
        
        private void Swap(List<int> originalList, int leftPointer, int rightPointer) {
            var temp = originalList[leftPointer];
            originalList[leftPointer] = originalList[rightPointer];
            originalList[rightPointer] = temp;
        }
    }
}
