using Xunit;
using System;

namespace CalculatorClassLibrary.Tests
{
    public class CalculatorTests
    {
        // SUM TESTS
        [Fact]
        public void ItShould_sumAllNumbersBetweenMinus500_and500()
        {
            foreach (var dataProvider in DataProvider.GetDataProvider("Sum.txt"))
            {
                Assert.Equal(dataProvider.expected, Calculator.Sum(dataProvider.a, dataProvider.b));
            }
        }

        [Fact]
        public void ItShould_sumSizeOfInt_and1_throwsException() => Assert.Throws<Exception>(
            () => Calculator.Sum(int.MaxValue, int.MaxValue));

        [Fact]
        public void ItShould_sumMinus10_and10_returns0() => Assert.Equal(0, Calculator.Sum(-10, 10));


        // DIVIDE TESTS
        [Fact]
        public void ItShould_divideAllNumbersBetweenMinus500_and500()
        {
            foreach (var dataProvider in DataProvider.GetDataProvider("Divide.txt"))
            {
                Assert.Equal(dataProvider.expected, Calculator.Divide(dataProvider.a, dataProvider.b));
            }
        }

        [Fact]
        public void ItShould_divide1_by0_throwsDivideByZeroException() =>
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(1, 0));

        [Fact]
        public void ItShould_divide1_byMinus1_returnsMinus1() => Assert.Equal(-1, Calculator.Divide(1, -1));

        // SUBSTRACT TESTS
        [Fact]
        public void ItShould_substract0_and5_returnsMinus5() => Assert.Equal(-5, Calculator.Substract(0, 5));

        [Fact]
        public void ItShould_substractAllNumbersBetweenMinus500_and500()
        {
            foreach (var dataProvider in DataProvider.GetDataProvider("Substract.txt"))
            {
                Assert.Equal(dataProvider.expected, Calculator.Substract(dataProvider.a, dataProvider.b));
            }
        }

        //MULTIPLY TESTS
        [Fact]
        public void ItShould_multiply0_and10_returns0() => Assert.Equal(0, Calculator.Multiply(0, 10));

        [Fact]
        public void ItShould_multiplyAllNumbersBetweenMinus500_and500()
        {
            foreach (var dataProvider in DataProvider.GetDataProvider("Sum.txt"))
            {
                Assert.Equal(dataProvider.expected, Calculator.Sum(dataProvider.a, dataProvider.b));
            }
        }
    }
}