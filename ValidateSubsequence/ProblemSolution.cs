using System;

namespace ValidateSubsequence
{
    public class ProblemSolution
    {
        private int[] _mainArray;
        private int[] _subsequenceArray;

        public ProblemSolution(int[] mainArray, int[] subsequenceArray)
        {
            _mainArray = mainArray;
            _subsequenceArray = subsequenceArray;
        }

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

        public void PrintArrays()
        {
            PrintArrayToConsole(_mainArray);
            PrintArrayToConsole(_subsequenceArray);
        }

        private void PrintArrayToConsole(int[] array)
        {
            if (array == null)
            {
                return;
            }

            Console.Write("[");
            for (int i=0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                    continue;
                }
                Console.Write($"{array[i]}, ");
            }
            Console.Write("]\r\n");
        }
    }
}

