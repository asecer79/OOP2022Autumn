using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06.ExtensionMethods
{
    public static class MyExtensions
    {
        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static int ToSquare(this int value)
        {
            return value * value;
        }

        public static double DotProd(this Point2D point1, Point2D point2)
        {
            return point1.X * point2.X + point1.Y * point2.Y;
        }

        public static double Distance(this Point2D point1, Point2D point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X,2) + Math.Pow(point1.Y - point2.Y,2));
        }

        //1 char shift to the right
        public static string Encrypt(this string value,int shiftLevel)
        {
            var encrypted = "";

            foreach (var c in value)
            {
                encrypted +=((char) (c + shiftLevel)).ToString();
            }

            return encrypted;
        }

        public static string Decrypt(this string value, int shiftLevel)
        {
            var decrypted = "";

            foreach (var c in value)
            {
                decrypted += ((char)(c - shiftLevel)).ToString();
            }

            return decrypted;
        }

        public static string TersCevir(this string value)
        {
            var reversed = "";
            var len = value.Length;

            for (int i = len-1; i >= 0; i--)
            {
                reversed += ((char)value[i]).ToString();
            }
          

            return reversed;
        }
    }
}
