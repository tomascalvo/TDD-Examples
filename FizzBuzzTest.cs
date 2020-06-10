using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xunitPractice
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange
            Calculator c = new Calculator();
            // Act
            double expected = 64;
            double actual = c.Add(48, 16);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8, 2)]
        [InlineData(16, 64)]
        [InlineData(3.14, 2.72)]
        public void SubtractTheory(double term1, double term2)
        {
            // Arrange
            Calculator c = new Calculator();
            // Act
            double expected;
            double actual = c.Subtract(term1, term2);
            expected = term1 - term2;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
    public class FizzBuzzTest
    {
        [Fact]
        public void TestDivisibleByFive()
        {
            // Arrange
            FizzBuzz fB = new FizzBuzz();
            // Act
            string expected = "fizz";
            string actual = fB.AnalyzeNum(10);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void FizzBuzzTheory(int num)
        {
            // Arrange
            FizzBuzz fB = new FizzBuzz();
            // Act
            string expected;
            string actual = fB.AnalyzeNum(num);
            if (num % 5 == 0 && num % 3 == 0)
            {
                expected = "fizzbuzz";
            }
            else if(num % 5 == 0)
            {
                expected = "fizz";
            }
            else if(num % 3 == 0)
            {
                expected = "buzz";
            }
            else
            {
                expected = num.ToString();
            }
        }
    }
}
