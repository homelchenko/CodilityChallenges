﻿using System;

namespace Codility.Lessons
{
    public class PermutationChecker
    {
        private const int MaxArrayLength = 100000;

        public bool IsPermutation(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            int permutationSum = (1 + array.Length) * array.Length / 2;

            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            return arraySum == permutationSum;
        }
    }
}