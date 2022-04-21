using NthFibonacci.App;
using Xunit;

namespace NthFibonacci.Test
{
    public class CalculateTheNthFibonacciNumberTest
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]

        public void NthFibTest1(int n, int expected)
        {
            //Arrange
            ICalculateTheNthFibonacciNumber calculateTheNthFibonacci = new CalculateTheNthFibonacciNumber();

            //Act
            var actual = calculateTheNthFibonacci.NthFib(n);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
