using UnideskTask;

namespace UnideskTaskTests
{
    public class InvalidTrianglesTests
    {

        [Theory]
        [InlineData(0, 0, 0, TriangleType.InvalidTriangle)]
        [InlineData(0, 0, 1, TriangleType.InvalidTriangle)]
        [InlineData(0, 1, 0, TriangleType.InvalidTriangle)]
        [InlineData(0, 1, 1, TriangleType.InvalidTriangle)]
        [InlineData(1, 0, 0, TriangleType.InvalidTriangle)]
        [InlineData(1, 0, 1, TriangleType.InvalidTriangle)]
        [InlineData(1, 1, 0, TriangleType.InvalidTriangle)]
        public void ZeroSideTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }

        [Theory]
        [InlineData(1, 1, -1, TriangleType.InvalidTriangle)]
        [InlineData(1, -1, 1, TriangleType.InvalidTriangle)]
        [InlineData(1, -1, -1, TriangleType.InvalidTriangle)]
        [InlineData(-1, 1, 1, TriangleType.InvalidTriangle)]
        [InlineData(-1, 1, -1, TriangleType.InvalidTriangle)]
        [InlineData(-1, -1, 1, TriangleType.InvalidTriangle)]
        [InlineData(-1, -1, -1, TriangleType.InvalidTriangle)]
        public void NegativeSideTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }

        [Theory]
        [InlineData(1, 1, 2, TriangleType.InvalidTriangle)]
        [InlineData(1, 2, 1, TriangleType.InvalidTriangle)]
        [InlineData(2, 1, 1, TriangleType.InvalidTriangle)]
        [InlineData(1, 1, 3, TriangleType.InvalidTriangle)]
        [InlineData(1, 3, 1, TriangleType.InvalidTriangle)]
        [InlineData(3, 1, 1, TriangleType.InvalidTriangle)]
        public void InvalidTriangleTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }
    }
}