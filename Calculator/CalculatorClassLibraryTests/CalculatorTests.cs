using Xunit;
using System;

namespace CalculatorClassLibrary.Tests
{
    public class CalculatorTests
    {
        // SUM TESTS
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Sum_ValidNumbers_ReturnsExpected(int value1, int value2, int expected)
        {
            var result = Calculator.Sum(value1, value2);

            Assert.Equal(expected, result);
        }

        // DIVIDE TESTS
        [Theory]
        [InlineData(55, 7, 7)]
        [InlineData(49, 7, 7)]
        [InlineData(-12, 7, -1)]
        [InlineData(-84, -84, 1)]
        public void Divide_ValidNumbers_ReturnsExpected(int value1, int value2, int expected)
        {
            var result = Calculator.Divide(value1, value2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            var value1 = 5;
            var value2 = 0;

            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(value1, value2));
        }

        // SUBSTRACT TESTS
        [Theory]
        [InlineData(5, 7, -2)]
        [InlineData(5, 5, 0)]
        [InlineData(20, 5, 15)]
        [InlineData(int.MinValue, 1, int.MaxValue)]
        public void Substract_ValidNumbers_ReturnsExpected(int value1, int value2, int expected)
        {
            var result = Calculator.Substract(value1, value2);

            Assert.Equal(expected, result);
        }

        //MULTIPLY TESTS
        [Theory]
        [InlineData(0, 100, 0)]
        [InlineData(5, 5, 25)]
        [InlineData(-2, 10, -20)]
        public void Multiply_ValidNumbers_ReturnsExpected(int value1, int value2, int expected)
        {
            var result = Calculator.Multiply(value1, value2);

            Assert.Equal(expected, result);
        }
    }
}