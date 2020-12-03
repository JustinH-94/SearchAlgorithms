using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Searching
{
    class Interpolation
    {
        Stopwatch sw = new Stopwatch();
        public void InterpolationSearch(List<int> scores, int playerRes)
        {
            
            int low = 0;//set low to be the bottom of the list
            int high = scores.Count - 1; //set high to be top of the list
            int index = 0; //creating index for it to be later used as the new starting point of being searched
            sw.Start();
            while(low<= high && playerRes >= scores[low] && playerRes <= scores[high])
            {
                index = low + ((playerRes - scores[low]) * (high - low) / (scores[high] - scores[low]));//arithmetic used to get a general start of where the item being searched for can be

                if (scores[index] == playerRes)//checks if the element at scores[index] is equal to the item
                    break;//if true, then break
                if (scores[index] < playerRes)//checks if the item being searched is greater than the value of the index
                    low = index + 1;// if true, set the new low to be the index + 1
                else
                    high = index - 1;// else, set the new high to be the index - 1
            }
            sw.Stop();
            WriteLine($"We found {playerRes} at index {index} of the sorted list using the Interpolation Algorithm. It took {sw.Elapsed.TotalMilliseconds/1000} seconds.");
            Description();
        }

        void Description()
        {
            WriteLine("Algorithm: Interpolation Search");
            WriteLine("Interpolation Search is a searching algorithm that takes a sorted array/list and locates\n" +
                "where the general area where the item being searched for is, and starts there. It is similar to\n" +
                "binary search in most aspects, what adding arithmetics make it quicker than Binary Search.");
            WriteLine("Best Case: O(log log n)\n" +
                "Worst Case: O(n)");
            WriteLine("InterpolationSearch(data[] scores, int item\n" +
                "low = 0\n" +
                "high = scores.count - 1\n" +
                "index =0\n" +
                "while low <= high and item >= scores[low] and item <= scores[high]\n" +
                "index = low + ((item - scores[low])*(high - low) / (scores[high] - scores[low]))\n" +
                "if scores[index] equal to item\n" +
                "break\n" +
                "end if\n" +
                "if scores[index < item\n" +
                "low = index + 1\n" +
                "end if\n" +
                "else" +
                "high = index - 1\n" +
                "end else" +
                "end InterpolationSearch()");
        }
    }
}
