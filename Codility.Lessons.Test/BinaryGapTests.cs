﻿using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void Solution_WhenNIsZero_ShouldReturnZero()
        {
            // Arrange

            // Act & Asseert
            AssertThatThereIsNoGap(0);
        }

        [Test]
        // Rename the test
        public void Solution_WhenNIs1_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(1);
        }

        [Test]
        public void Solution_WhenNIsFive_ShouldReturn1()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(1);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void ConvertToBinary_WhenZero_ShouldReturnEmpty()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            string binary = binaryGap.ConvertToBinary(0);

            // Assert
            binary.Should().BeEmpty();
        }

        private static void AssertThatThereIsNoGap(int input)
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(input);

            // Assert
            maxGapLength.Should().Be(0);
        }

        // TODO: Test for Int.Max
        // TODO: Test for negative input
    }
}
