using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Searching
{
    class Linear
    {
        int index = 0;
        Stopwatch sw = new Stopwatch();
        public void LinearSearch(List<int> scores, int playerRes)
        {
            sw.Start();
            for(int i = 0; i < scores.Count - 1; i++)//loop the entire list
            {
                if (scores[i] == playerRes)//if the element at scores[i] is equal to the value give by the user then ...
                {
                    index = i; //set the index to i, and break out of the loop.
                } 
            }
            sw.Stop();
            WriteLine($"Found {playerRes} at index {index} for the unsorted list. It took {sw.Elapsed.TotalMilliseconds / 1000} seconds");
            Description();
        }

        void Description()
        {
            WriteLine("Algorithm: Linear Search");
            WriteLine("Linear Search is a simple algorithm that searches for a specific element in the\n" +
                "array/list one element at a time. This is a simple, yet effective, algorithm for shorter\n" +
                "arrays/list; however, if the size of the array/list is massive. It could take longer than\n" +
                "most algorithms.");
            WriteLine("Best Case: O(1)\n" +
                "Worst Case: O(n)\n" +
                "Average Case: O(n/2)");
            WriteLine("LinearSearch( data[] scores, int item\n" +
                "i equal 0 to length of score - 1\n" +
                "if score at i is equal to item\n" +
                "return the index\n" +
                "end if\n" +
                "increment i\n" +
                "end i loop\n" +
                "end LinearSearch");
        }
    }
}
