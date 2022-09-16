# Problem: validate subsequence

You are given two arrays: the main array and a subsequence array, which is either smaller or the same size as the main array.
The goal is find out if the main array contains all the elements of the subsequence array in the same order.
**Note**: The main array does not need to contain the elements of the subsequene array consequtively, it may contain some extra elements which can be skipped. But the order of the subsequence array must be maintained.

Example:
Given array: `[5, 1, 22, 25, 6, -1, 8, 10, 11, 7]`
Given subsequence array: `[1, 6, -1, 10]`
The expected output should be: `true` since the numbers from the subsequence array are present in the main array
in the same order. 

## Solution using a loop with a single iteration

The following solution uses O(n) complexity for time and O(1) complexity for space since only pointers are used and nothing is stored anywhere for comparison.

A for loop or a while loop can be used to solve the problem, they will both yeild the same result. Remember some extra checks 
must be there in place for the while loop to function properly.

Two separate pointers can be used each starting from the start of the arrays, pointing to the current index.
Compare if the current subsequence array's element is equal to the main array's element, if it is the same then simply increment 
both and point to the next values. If all the elements in the subsequence array is compared and found in the main array, simply 
exit the main array's loop and return `true` suggesting that the main array contains all the elements. If the main array's iteration is over and the subsequence array is still pointing to an element, then return `false` since the main array does not contain all 
the elements.  


```csharp
public bool Solution()
{
    bool result = false;
    int subPointer = 0;

    for (int i=0; i < _mainArray.Length; i++)
    {
        if (_mainArray[i] == _subsequenceArray[subPointer])
        {
            subPointer++;
        }

        if (subPointer == _subsequenceArray.Length)
        {
            result = true;
            break;
        }
    }

    return result;
}
```
