# Problem: two number sum

There will an even numbered given array of integers (either positive or negative) and a target sum stated for the problem.
The goal is find a pair of integers that can add up to produce the target sum.

Example:
Given array: `[3, 5, -4, 8, 11, 1, -1, 6]`
Given target sum: `10`
The expected output should be: `[11,-1]` or `[-1,11]`

## Solution using a dictionary

The following solution uses O(n) complexity for time and O(1) complexity for space.
The array can be iterated just once and during the iteration a difference should be calculated as:  
`var difference = targetSum - array[i]`
If the different already belongs to the checker dictionary then that means that value was iterated earlier,
so store the difference and current ith value in the result array and return the result.
Otherwise, store the current ith value in the dictionary as the key and continue with the loop.

```csharp
 foreach (var num in _numbers)
{
    var difference = _targetSum - num;
    if (sumDict.ContainsKey(difference))
    {
        result[0] = num;
        result[1] = difference;
        break;
    } else
    {
        sumDict.Add(num, true);
    }
}
```

## Solution using sorting

The following solution uses O(n log n) time complexity and O(i) space complexity.
We can use the built in `Array.Sort()` method, which uses quicksort in `C#` to first sort the array.
Other languages will also have their own basic sorting library implemented for usage.

Iterate through the sorted array keeping a left index starting at 0 and right index of total length minus 1.
Calculate the sum of the left and right position's integer values, return them if result is found.
Otherwise, compare if the sum is less than the target, then increment the left index.
If the sum is more than the target sum then decrement the right index.

```csharp
int left = 0, right = _numbers.Length-1;
while (left < right)
{
    int value = _numbers[left] + _numbers[right];
    if (value == _targetSum)
    {
        result[0] = _numbers[left];
        result[1] = _numbers[right];
        break;
    }

    if (value < _targetSum)
    {
        left++;
    }
    else if (value > _targetSum)
    {
        right--;
    }
}
```
