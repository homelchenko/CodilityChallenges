﻿using System;

namespace Codility.Lessons
{
    public class MissingElementFinder
    {
        private const int MaxArrayLength = 100001;

        public int FindMissingElement(int[] array)
        {
            if (array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            // In checked context this will throw due to overflow,
            // but it produces correct results as unit tests prove

            int maxPossibleArrayValue = array.Length + 1;
            int maxPossibleSum = (1 + maxPossibleArrayValue) * maxPossibleArrayValue / 2;

            int actualSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                actualSum += array[i];
            }

            return maxPossibleSum - actualSum;
        }
    }
}
