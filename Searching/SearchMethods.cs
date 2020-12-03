using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
namespace Searching
{
    class SearchMethods
    {
        Linear linear = new Linear();
        Binary binary = new Binary();
        SortList sort = new SortList();
        Interpolation inter = new Interpolation();

        List<int> scores = new List<int>();
        string[] tempList;
        public int playerRes;
        public SearchMethods()
        {
            ExtractData();
            AskForNum();
            linear.LinearSearch(scores, playerRes);
            Util();
            scores = sort.sortList(scores);
            binary.binarySearch(scores, playerRes);
            Util();
            inter.InterpolationSearch(scores, playerRes);
            Util();
            Summary();
            ReadKey(true);
        }

        void ExtractData()
        {
            tempList = File.ReadAllLines("scores.txt");
            for(int i = 0; i < tempList.Length; i++)
                scores.Add(Convert.ToInt32(tempList[i]));
        }

        void AskForNum()
        {
            WriteLine("Which number would like this program to search for in the list of scores (0-100): ");
            playerRes = Convert.ToInt32(ReadLine());
        }

        void Util()
        {
            WriteLine("Press Any Key To Continue");
            ReadKey(true);
            Clear();
        }

        void Summary()
        {
            WriteLine("After seeing the time results of each algorithm. I found that Interpolation Search to be\n" +
                "the quickest amongest the algorithm. With Linear Search following shortly behind. Also, Binary\n" +
                "Search, for whatever reason, seemed to have been drastically slower than the other two. I don't\n" +
                "know if it's the alogirthm I designed, or amongst other things. I think the reason Interpolation\n" +
                "is the fastest because it reduced its general search area more than Binary Search and certainly\n" +
                "Linear Search(linear search using the entire length of the list to search for the item).");
        }
    }
}
