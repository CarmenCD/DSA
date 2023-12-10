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

            Assert.Equal(expected[2], input[2]);
            Assert.Equal(expected[7], input[7]);
        }

        [Fact]
        public void TestLoops()
        {
            var n = 100;
            
            //var i = 1;
            /*while (i < n)
            {
                var x = i;
                var count = 0;

                while (x-- > 0)
                {
                    count++;
                    //some code
                    
                }

                i++;
            }*/

            for (var i = 0; i <= n; i++)
            {
                var count = 0;
                for (var j = i; j <= n && j > i; j++)
                {
                    count++;
                }
            }

        }
    }
}
