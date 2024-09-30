namespace AreaOfFigures
{
    public class Square
    {
        public static double AreaOfACircle(double R)
        {
            if (R < 0) return -1;
            return Math.Round(Math.PI * R * R, 2);
        }

        public static double AreaOfATriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return -1;
            double perimeter = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c)), 2);
        }

        public static bool RectangularityOfTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;
            double maxSide = Math.Max(Math.Max(a, b), c);
            double minSide = Math.Min(Math.Max(a, b), c);
            double middleSide = (a + b + c) - maxSide - minSide;
            return Math.Pow(maxSide, 2) == Math.Pow(middleSide, 2) + Math.Pow(minSide, 2);
        }
    }
}