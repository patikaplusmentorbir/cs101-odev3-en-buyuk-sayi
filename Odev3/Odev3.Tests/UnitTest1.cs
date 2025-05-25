using Xunit;
using Odev3;

namespace Odev3.Tests
{
    public class OdevTest
    {
        [Fact]
        public void TestFindMax()
        {
            Assert.Equal(5, Odev.FindMax(new int[] { 1, 3, 5 }));
            Assert.Equal(10, Odev.FindMax(new int[] { 10, 2, 8 }));
            Assert.Equal(-1, Odev.FindMax(new int[] { -5, -3, -1 }));
            Assert.Equal(100, Odev.FindMax(new int[] { 100 }));
        }
    }
}
