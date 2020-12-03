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
        break;
    }
}
```
