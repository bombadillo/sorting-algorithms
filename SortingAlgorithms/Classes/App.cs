namespace SortingAlgorithms.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class App : IApp
    {
        private readonly ILog Logger;
        private readonly IQuickSort QuickSorter;


        public App(ILog logger, IQuickSort quickSorter)
        {
            Logger = logger;
            QuickSorter = quickSorter;
        }

        public void Run()
        {
            int[] values = { 2, 4, 1, 9, 3, 8, 6, 20, 43, 41, 29 };
            var bubbleList = new List<int>(values);
            var quickList = new List<int>(values);

            BubbleSort(bubbleList);
            QuickSort(quickList);

            Console.ReadKey();
        }

        public static void BubbleSort(List<int> bubbleList)
        {
            Console.WriteLine("========= Bubble Sort =========");

            foreach (var item in bubbleList)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine("");

            BubbleSorter.Bubble(bubbleList);

            Console.WriteLine("");

            foreach (var item in bubbleList)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine("");
        }

        public void QuickSort(List<int> quickList)
        {

            Console.WriteLine("========= Quick Sort =========");

            QuickSorter.Iterations = 0;

            foreach (var item in quickList)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine("");

            QuickSorter.Sort(quickList);

            Console.WriteLine("");

            foreach (var item in quickList)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine("{0} iterations", QuickSorter.Iterations);
        }
    }
}
