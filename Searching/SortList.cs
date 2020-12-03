using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class SortList
    {
        public List<int> sortList(List<int> scores)
        {
            for(int i = 0; i < scores.Count - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if(scores[j] < scores[j - 1])
                    {
                        var temp = scores[j - 1];
                        scores[j - 1] = scores[j];
                        scores[j] = temp;
                    }
                }

            }
            return scores;
        }
    }
}
