namespace UnideskTask
{
    public static class TriangleClassifier
    {

        public static readonly double MaxAcceptableDoubleValue = Math.Sqrt(double.MaxValue) / 2;

        public const double DefaultPrecision = 0.0000000001;

        public static TriangleType GetTriangleType(double a, double b, double c, double precision = DefaultPrecision)
        {
            if (precision <= double.Epsilon)
            {
                return TriangleType.NonClassifiableTriangle;
            }

            if (!IsValidTriangle(first: a, second: b, third: c))
            {
                return TriangleType.InvalidTriangle;
            }

            if (!IsClassifiableTriangle(first: a, second: b, third: c))
            {
                return TriangleType.NonClassifiableTriangle;
            }

            SortSidesDESC(first: ref a, second: ref b, third: ref c);

            double aSquared = a * a;
            double bSquared = b * b;
            double cSquared = c * c;
            double diff = Math.Abs(aSquared - bSquared - cSquared);
            if (diff < precision)
            {
                return TriangleType.RightTriangle;
            }
            else if (aSquared - bSquared - cSquared > 0)
            {
                return TriangleType.ObtuseTriangle;
            }
            else
            {
                return TriangleType.AcuteTriangle;
            }
        }

        public static bool IsValidTriangle(double first, double second, double third)
        {
            if (first <= double.Epsilon || second <= double.Epsilon || third <= double.Epsilon)
            {
                return false;
            }

            if (first >= second + third || second >= first + third || third >= first + second)
            {
                return false;
            }

            return true;
        }

        public static bool IsClassifiableTriangle(double first, double second, double third)
        {
            if (first >= MaxAcceptableDoubleValue)
            {
                return false;
            }

            if (second >= MaxAcceptableDoubleValue)
            {
                return false;
            }

            if (third >= MaxAcceptableDoubleValue)
            {
                return false;
            }

            return true;
        }

        public static void SortSidesDESC(ref double first, ref double second, ref double third)
        {
            double temp = first;
            if (second > first)
            {
                first = second;
                second = temp;
            }
            // at this point a >= b
            temp = first;
            if (third > first)
            {
                first = third;
                third = temp;
            }
            // at this point a >= b && a >= c
            temp = second;
            if (third > second)
            {
                second = third;
                third = temp;
            }
            // Now we have variables sorted
        }

    }
}
