namespace TwoNumberSum
{
    public class TwoNumberSumSolution
    {
        private int[] _numbers { get; set; }
        private int _targetSum { get; set; }

        public TwoNumberSumSolution(int[] numbers, int targetSum)
        {
            _numbers = numbers;
            _targetSum = targetSum;
        }

        public int[] SolutionWithDictionary()
        {
            var result = new int[2];
            var sumDict = new Dictionary<int, bool>();

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

            return result;
        }

        public int[] SolutionWithSort()
        {
            var result = new int[2];
            Array.Sort(_numbers);

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

            return result;
        }
    }
}
