using UnideskTask;

namespace UnideskTaskTests
{
    public class ValidTrianglesTests
    {
        [Theory]
        [InlineData(3, 4, 5, TriangleType.RightTriangle)]
        [InlineData(5, 12, 13, TriangleType.RightTriangle)]
        [InlineData(7, 24, 25, TriangleType.RightTriangle)]
        [InlineData(8, 15, 17, TriangleType.RightTriangle)]
        public void PyphagorianTrianglesTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }

        [Theory]
        [InlineData(5, 3, 3, TriangleType.ObtuseTriangle)]
        [InlineData(6, 5, 3, TriangleType.ObtuseTriangle)]
        public void ObscureTrianglesTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }

        [Theory]
        [InlineData(1, 1, 1, TriangleType.AcuteTriangle)]
        [InlineData(2, 3, 3, TriangleType.AcuteTriangle)]
        public void AcuteTrianglesTest(double value1, double value2, double value3, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3);

            Assert.Equal(expected, type);
        }
    }
}
