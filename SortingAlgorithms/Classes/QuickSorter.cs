namespace SortingAlgorithms.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    
    public class QuickSorter : IQuickSort {

        public int Iterations { get; set; }

        public List<int> Sort(List<int> items, int left = 0, int right = 0) {

            if (right == 0) 
                right = items.Count - 1;
        
            var index = Partition(items, left, right);
        
            if (left < index - 1) {
              Sort(items, left, index - 1);
            }
        
            if (index < right) {
              Sort(items, index, right);
            }            

            return items;
        }
        
        private int Partition(List<int> items, int left, int right) {
            
            var pivot   = items[(right + left) / 2];
            var i       = left;
            var j       = right;
        
        
            while (i <= j) {
        
                while (items[i] < pivot) {
                    i++;
                    Iterations++;
                }
        
                while (items[j] > pivot) {
                    j--;
                    Iterations++;
                }
        
                if (i <= j) {
                    Swap(items, i, j);
                    i++;
                    j--;
                    Iterations++;
                }

                Iterations++;
            }
        
            return i;
        }
        
        private void Swap(List<int> originalList, int leftPointer, int rightPointer) {
            var temp = originalList[leftPointer];
            originalList[leftPointer] = originalList[rightPointer];
            originalList[rightPointer] = temp;
        }
    }
}
