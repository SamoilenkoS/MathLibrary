using NUnit.Framework;
using System;

namespace MathLibrary.UnitTests
{
    public class Tests
    {
        [TestCase(5, 7, 10, 10)]
        [TestCase(5, 10, 3, 10)]
        [TestCase(10, 7, 1, 10)]
        [TestCase(-5, -7, -10, -5)]
        public void Max_WhenCalled_ShouldFindMaxValue(int a, int b, int c, int expectedResult)
        {
            int actualResult = MathHelper.Max(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new[] { 1, 4, 3, 1 }, 4)]
        [TestCase(new[] { 4, 2, 3, 1 }, 4)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -5, -7 }, -5)]
        public void Max_WhenArrayFilled_ShouldFindMaxValue(int[] sourceArray, int expectedResult)
        {
            var actualResult = MathHelper.Max(sourceArray);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Max_WhenArrayEmptyOrNull_ShouldThrowArgumentException(int[] sourceArray)
        {
            try
            {
                MathHelper.Max(sourceArray);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}