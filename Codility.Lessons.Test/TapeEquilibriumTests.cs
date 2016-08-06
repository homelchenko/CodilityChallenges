﻿using System;
using NUnit.Framework;
using FluentAssertions;

namespace Codility.Lessons.Test
{

    [TestFixture]
    public class TapeEquilibriumTests
    {
        [Test]
        public void FindEquilibrium_WhenEmptyArray_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertFindEquilibriumThrows(emptyArray);
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsSingleElement_ShouldThrow()
        {
            // Arrange
            int[] singleItemArray = new int[1] { 5 };

            // Act & Assert
            AssertFindEquilibriumThrows(singleItemArray);
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsTwoElementAndSecondDifferenceIsGreaterThanFirstOne_ShouldReturnZero()
        {
            // Arrange
            int expected = 0;

            int[] array = new int[2] { 1, -2 };
            
            // Act & Assert
            AssertEquilibriumIs(array, expected);
        }

        [Test]
        public void FindEquilibirium_WhenArrayContainsTwoElementAndSecondDifferenceIsSmallerThanFirstOne_ShouldReturnOne()
        {
            // Arrange
            int expected = 1;

            int[] array = new int[2] { -1, -2 };

            // Act & Assert
            AssertEquilibriumIs(array, expected);
        }

        [Test]
        public void FindEquilibrium_WhenDifferencesAreNegativeAndSecondDifferenceIsGreaterThanFirstOne_ShouldReturnOne()
        {
            // Arrange
            int[] array = new int[2] { 1, 2 };

            // Act & Assert
            AssertEquilibriumIs(array, 1);
        }

        private static void AssertEquilibriumIs(int[] array, int expected)
        {
            // Act
            int equilibrium = CreateTapeEquilibrium().FindEquilibrium(array);

            // Arrange
            equilibrium.Should().Be(expected);
        }

        private static void AssertFindEquilibriumThrows(int[] array)
        {
            // Arrange
            Action findEquilibrium = () => CreateTapeEquilibrium().FindEquilibrium(array);

            // Act & Assert
            findEquilibrium.ShouldThrow<ArgumentOutOfRangeException>();
        }

        private static TapeEquilibrium CreateTapeEquilibrium()
        {
            return new TapeEquilibrium();
        }
    }
}
