using DataStructures.Practice.Arrays;

namespace DataStructures.XUnit.UnitTests.Practice.Arrays
{
    public class ArraysPracticeTest
    {
        [Theory]
        [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new[] { 3, 2, 2, 4, 5, 3, 7, 2, 3, 4, 4, 3 }, 3, 8)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 3, 7)]
        [InlineData(new[] { 4, 5 }, 5, 1)]
        public void RemoveElement_ShouldDuplicateZeroValuesInArray(int[] input, int val, int expected)
        {
            var sut = new ArraysPractice();
            var result = sut.RemoveElement(input, val);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        public void DuplicateZeros_ShouldDuplicateZeroValuesInArray(int[] input, int[] expected)
        {
            var sut = new ArraysPractice();
            sut.DuplicateZeros(input);
            Assert.Equal(expected[2], 0);
            Assert.Equal(expected[5], 0);
            Assert.Equal(expected[6], 0);
        }
    }
}
