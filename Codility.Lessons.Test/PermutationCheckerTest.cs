﻿using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class PermutationCheckerTest
    {
        [Test]
        public void IsPermutation_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(emptyArray);
        }

        [Test]
        public void IsPermutation_WhenArrayIsLongerThanMaxLength_ShouldThrow()
        {
            // Arrange
            var lengthLongerThanMax = 100001;

            int[] arrayLongerThanMax = new int[lengthLongerThanMax];

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(arrayLongerThanMax);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsSingleItemAndIsOne_ShouldReturnTrue()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 1 };

            // Act & Assert
            AssertIsPermutation(oneItemArray);
        }

        private static void AssertIsPermutation(int[] array)
        {
            // Arrange
            PermutationChecker permutationChecker = CreatePermutationChecker();

            // Act
            bool isPermutation = permutationChecker.IsPermutation(array);

            // Assert
            isPermutation.Should().BeTrue();
        }

        private static void AssertIsPermutationThrowsArgumentException(int[] array)
        {
            // Arrange
            PermutationChecker permutationChecker = CreatePermutationChecker();

            Action isPermutation = () => permutationChecker.IsPermutation(array);

            // Act & Assert
            isPermutation.ShouldThrow<ArgumentException>();
        }

        private static PermutationChecker CreatePermutationChecker()
        {
            return new PermutationChecker();
        }
    }
}
