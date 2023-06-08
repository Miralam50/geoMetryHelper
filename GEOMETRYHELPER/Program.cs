using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public static class GeometryHelper
    {
        const double pi = 3.14d;
         public static decimal DordBucaqSahesi(decimal uzunluq,decimal en)
        {
            return uzunluq * en;
        }

        public static decimal UcBucaqSahesi (decimal oturacaq, decimal hundurluk)
        {
            return (oturacaq * hundurluk)/2;
        }

        public static double DaireSahesi(double radius)
        {

            return pi * Math.Pow(radius,2);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Dordbucagin sahesi: " + GeometryHelper.DordBucaqSahesi(4, 10));
           Console.WriteLine("Ucbucagin sahesi: " + GeometryHelper.UcBucaqSahesi(15, 10));
           Console.WriteLine("Dairenin sahesi: " + GeometryHelper.DaireSahesi(5));
        }
    }
}