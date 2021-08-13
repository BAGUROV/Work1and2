using System;

namespace Math
{
    public class Geometry
    {
        public const double PI = 3.1415926535897931;
        public static double AreaСircle(double radus)
        {
            if(radus < 0)
                throw new ArgumentException(radus+ " отрицательное число");
            return PI * radus * radus;
        }
        private static void SwapPlaces(ref double side1, ref double side2, ref double side3)
        {
            double leg1 = side1, max = side3;
            if (max < side2)
            {
                side3 = side2;
                side2 = max;
            }

            if (side3 < side1)
            {
                side1 = side3;
                side3 = leg1;
            }
        }
        private static string FindTypeTriangle(double side1, double side2, double side3)
        {
            if (side1 == side2 & side3 == side2)
                return "Равносторонний";
            else if ((side1 + side2 <= side3) || (side3 + side2 <= side1) || (side1 + side3 <= side2))
                return "Не существует";
            else if ((side1 == side2 & side1 != side3) || (side3 == side2 & side1 != side3) || (side1 == side3 & side1 != side2))
                return "Равнобедренный";
            if ((side3 * side3) == ((side1 * side1) + (side2 * side2)))
                return "Прямоугольный";
            else
                return "Разносторонний";
        }
        public static double AreaTriangle(double side1, double side2, double side3)
        {
            SwapPlaces(ref side1, ref side2, ref side3);
            switch (FindTypeTriangle(side1, side2, side3))
            {
                case "Не существует":
                    return -1;
                case "Прямоугольный":
                    return (side1* side2) /2;
                case "Равносторонний":
                    return (side1* side1 * System.Math.Sqrt(3)) / 4;
                case "Разносторонний":
                    double p = (side1 + side2 + side3) / 2;
                    return System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                case "Равнобедренный":
                    double equalSide, baseTriangle = side1 == side2 ? side3 : side1;
                    baseTriangle = side1 == side3 ? side2 : side1;
                    equalSide = side1 == baseTriangle ? side2 : side1;
                    return (baseTriangle / 4) * System.Math.Sqrt((4* equalSide * equalSide) - (baseTriangle * baseTriangle));
            }
            return 0;
        }
    }
}
