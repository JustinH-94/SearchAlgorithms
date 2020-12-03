# SearchAlgorithms
This repository shows example code I made that demonstrates my understanding of the search algorithms: Linear Search, Binary Search, and
Interpolation Search. The codes demonstrated extract data from a file and places that data into a int list. It will then prompt a value
between 0 and 100. The code will take that input and find that item in the unsorted and sorted versions of the list using the three different
algorithms. While being timed, to find which algorithm is the most efficient.

## Linear Search
Linear Search was the second fastest algorithm to find elements. I made a simple for loop structure and inside is an if statement that
checks whether element of scores[i] was equal to the input the player gave. If yes, then the index would equal that i.
```C#
for(int i = 0; i < scores.count-1; i++)
{
    if(scores[i] == playerRes)
    {
        index = i;
    }
}
```

## Binary Search
Binary Search has been the slowest amongst the three algorithms in finding the item. For reasons I don't know. Binary takes a sorted array/list data, and searches by splitting the data in halves. So, my example shows the code calculating the mid point of the array/list and see if the element in that mid is equal to the item. If not, then the it'll check if the item is less than the 
midpoint element. If true, then the new high point of the search is the mid - 1. If false, then the new low would be mid + 1. Meaning that the item cannot be in the bottom half of the list, so code ignores that half.

```C#
L = 0;
R = scores.count -1;
While (L <= R)
    int mid = L + ( R-L ) /2;
    if(scores[mid] = playerRes)
         return mid;
    if(scores[mid] < playerRes)
         L = mid + 1;
    else
         R = mid - 1;
```

## Interpolation Search
Interpolation search is a search algorithm that has ran the quickest among the three algorithm. Interpolation is similar to Binary is overall structure of code. However, Interpolation doesn't calculate the midpoint of the array/list, but rather the general area of where the item being search for is. So there is a new arithmetic being placed instead of the mid calculation.

```C#
int low = 0;
int high = scores.Count - 1;
int index = 0;
while(low<= high && playerRes >= scores[low] && playerRes <= scores[high])
            {
                index = low + ((playerRes - scores[low]) * (high - low) / (scores[high] - scores[low]));

                if (scores[index] == playerRes)
                    break;
                if (scores[index] < playerRes)
                    low = index + 1;
                else
                    high = index - 1;
            }
```
