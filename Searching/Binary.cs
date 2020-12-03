using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Searching
{
    class Binary
    {
        Stopwatch sw = new Stopwatch();
        public void binarySearch(List<int> scores, int playerRes)
        {
            int right = scores.Count-1;//set the right to be the length of the list - 1
            int left = 0; //set the left to be 0
            sw.Start();
            int result = Search(scores, playerRes, left, right); //pass in values to the method for it to be return with no results or finding the placement of the searched item
            sw.Stop();
            if(result == -1)
                WriteLine("We have not found your response in the list.");
            else 
                WriteLine($"We found {playerRes} within the sorted list at index {result} using the Binary Search algorithm. It took {sw.Elapsed.TotalMilliseconds / 1000} seconds.");
            Description();
        }

        int Search(List<int> scores, int playerRes, int L, int R)
        {
            while( L <= R)//loops while left is less than or equal to right
            {
                int mid = L + (R - L) / 2; //setting the mid to the array size for it be the new left or high later on. (or if them item is in the mid)

                if (scores[mid] == playerRes) //checks to see if the item is in the middle of this section of the list
                    return mid;//returns the value of mid if true
                if (scores[mid] < playerRes)//checks to see if them item being searched for is greater than the value of scores[mid]
                    L = mid + 1;//if true, then the new left(low value) is the mid + 1 since it knows item is not in the lower half of the list
                else
                    R = mid - 1;//else, the new right( high value) is mid - 1 since it knows the item is not in the upper half of the list
            }
            return -1; //returns -1 is nothing was found
        }
        void Description()
        {
            WriteLine("Algorithm: Binary Search\n" +
                "Binary Search is a searching algorithm that splits the sorted array/list.\n" +
                "It takes the value being searched for see's if it's greater than or less\n" +
                "than the mid of the array/list. If it's great than, then the low becomes\n" +
                "the mid plus one. If it's less than, then the high becomes the mid minus\n" +
                "one. This keeps happening until mid of the array/list is the same value as\n" +
                "searched item.");
            WriteLine("Best & Worst Case: O(log n)");
            WriteLine("binarySearch(data[] scores, int item)\n" +
                "set right equal to the size of scores - 1\n" +
                "set left to 0\n" +
                "while left <= right do\n" +
                "set mid = left + ( right - left) /2\n" +
                "if scores[mid] = to item\n" +
                "return mid\n" +
                "end if\n" +
                "if scores[mid] < item\n" +
                "left = mid + 1\n" +
                "end if" +
                "else\n" +
                "right = mid - 1\n" +
                "end else\n" +
                "end while loop\n" +
                "end binarySearch()");
        }
    }
}
