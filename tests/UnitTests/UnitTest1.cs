using System;
using Xunit;

using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Divide_WithTwoInts()
        {
            var expected = 3;
            var a = 6;
            var b = 2;
            var actual = Divide(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_WithZero()
        {
            var expected = 0;
            var a = 0;
            var b = 6;
            var actual = Divide(a, b);
            Assert.Equal(expected, actual);
        }




        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-6, -2, 3)]
        [InlineData(-8, 2, -4)]
        public void Divide_WithMultipleInputs(int n1, int n2, int value)
        {
            Assert.Equal(Divide(n1, n2), value);
        }



        int Divide(int x, int y)
        {
            return x / y;
        }


    }
}