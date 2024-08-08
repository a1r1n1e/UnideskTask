using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnideskTask;

namespace UnideskTaskTests
{
    public class PrecisionTests
    {
        [Theory]
        [InlineData(3, 4, 5, -1, TriangleType.NonClassifiableTriangle)]
        [InlineData(3, 4, 5, 0, TriangleType.NonClassifiableTriangle)]
        public void InvalidPrecisionTest(double value1, double value2, double value3, double precision, TriangleType expected)
        {
            var type = TriangleClassifier.GetTriangleType(a: value1, b: value2, c: value3, precision: precision);

            Assert.Equal(expected, type);
        }
    }
}
