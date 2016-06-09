namespace SortingAlgorithms.Classes
{
    using System;
    using System.Collections.Generic;
    
    public class BubbleSorter {
        
        public static List<int> Bubble(List<int> originalList) {
            
            var iterations = 0;
            
            for (var i = 0; i < originalList.Count - 1; i++) {
                for (var j = 0; j < originalList.Count - 1; j++) {
                    if (originalList[j] > originalList[j + 1]) {
                        var temp = originalList[j + 1];
                        originalList[j + 1] = originalList[j];
                        originalList[j] = temp;
                    }
                    iterations++;
                }   
                iterations++;
            }

            Console.WriteLine("{0}{1} iterations ", Environment.NewLine, iterations);
            
            return originalList;
        }       
    }
}
