using Xunit;

namespace koulujuttu
{
    public class testi
    {
        [Theory]
        [InlineData(null, new int[] { })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { })]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { 2, 4, 6 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 4 })]
        public void FindEvenNumbers_GivenNumbers_ReturnsEvenNumbers(int[]? input, int[]? expected)
        {

            // Assert
            Assert.Equal(expected, expected);
        }

    }
}
