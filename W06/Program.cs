
using System.Runtime.Intrinsics.Arm;
using W06.ExtensionMethods;
using W06.OperatorOverloading;

namespace W06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point();
            //p1.X = 1;
            //p1.Y = 2;


            //Point2D p2 = new Point2D();
            //p2.X = 1;
            //p2.Y = 2;

            //Console.WriteLine($"for struct: p1.X, p1.Y = {p1.X}, {p1.Y}, for class: p2.X, p2.Y = {p2.X}, {p2.Y}");

            //MultiplyByConstant(p1, 2);
            //MultiplyByConstant(p2, 2);

            //Console.WriteLine($"for struct: p1.X, p1.Y = {p1.X}, {p1.Y}, for class: p2.X, p2.Y = {p2.X}, {p2.Y}");

            ////.. here Point p1 has not changed
            //.. here Point2D p2 has changed


            //int num1 =  Console.ReadLine().ToInt();
            //int num2 = Console.ReadLine().ToInt();

            // Console.WriteLine(num1+num2);

            //Console.WriteLine("1".ToInt()+"2".ToInt());

            //Console.WriteLine(25.ToSquare());


            //Point2D p1 = new Point2D(){X = 2,Y = 3};
            //Point2D p2 = new Point2D() { X = -2, Y = -3 };

            //var result = p1.DotProd(p2);
            //Console.WriteLine(result);

            //Console.WriteLine(p1.Distance(p1));
            // var clearText = "Aydın";

            //var enc = clearText.Encrypt(15);
            //Console.WriteLine(enc);

            //var dec = enc.Decrypt(15);
            //Console.WriteLine(dec);

            //Console.WriteLine(clearText.TersCevir());



            ComplexNumber c1 = new ComplexNumber() { X = 1, Y = -1 };   //1 + i; 
            ComplexNumber c2 = new ComplexNumber() { X = 1, Y = 1 };   //1 + i; 

            //if (c1==c2)
            //    Console.WriteLine("They are equal");
            //else
            //    Console.WriteLine("They are not equal");

            // //string n = c2;

            // //Console.WriteLine(n);
            // ComplexNumber c3 = (ComplexNumber)"1,2";   //1+2i

            // Console.WriteLine(c3);
            // Console.WriteLine(c3.ToString());

            // ComplexNumber c4 =(ComplexNumber) "1,2";   //1+2i

            //Console.WriteLine(c1.ToString());



            //Console.WriteLine((c1+ c2).ToString());
            //Console.WriteLine((c1 - c2).ToString());
            //ComplexNumber c3 = 2 + c1 + 4 - c1 - 6 + c1 * 2;



            //  Console.WriteLine(c3.ToString());

            // Console.WriteLine((5*c1*2).ToString());

            //Console.WriteLine(c1*c2);


            //anonymous types//especiall can be used in manipulation of Json Objects
            var addressInfo = new { home = "asdasd", city = "Istanbul" };


            var myInfo = new { name = "Aydın", age = 40, address = addressInfo };

            Console.WriteLine(myInfo.age);
            Console.WriteLine(myInfo.address.city);

        }

        static void MultiplyByConstant(Point2D point, int num)
        {
            point.X = point.X * num;
            point.Y = point.Y * num;

            Console.WriteLine($"for class: p2.X, p2.Y = {point.X}, {point.Y}");
        }
        static void MultiplyByConstant(Point point, int num)
        {
            point.X = point.X * num;
            point.Y = point.Y * num;

            Console.WriteLine($"for struct: p2.X, p2.Y = {point.X}, {point.Y}");
        }
    }


    //reference type
    public class Point2D
    {

        public double X { get; set; }

        public double Y { get; set; }

        public double Module()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }


    #region Structs
    //P(x,y)
    //value type
    public struct Point
    {

        public double X { get; set; }

        public double Y { get; set; }

        public double Module()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }

    #endregion

    #region Class Types

    //regular normal class/
    //can be instantiated,by new keyword
    //can be inherited,
    //can implement  interfaces
    //can inherit,
    //may have static and instance members
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    //abstract class
    //can not be initialized/ by new keyword
    //can be inherited
    //can inherit
    //can implement  interfaces
    //may have static and instance members
    // can be used as Interfaces
    public abstract class MathOperation
    {
        public double PI { get; set; }

        static MathOperation()
        {

        }
        //concrete
        public int Sum(int a, int b)
        {
            return a + b;
        }

        //abstract method
        public abstract int Divide(int a, int b);
    }



    //static class
    //can not be initialized/ by new keyword
    //can not be inherited
    //all members must be static
    //can inherit
    //can not implement  interfaces

    public static class Algebra
    {
        public static double PI { get; set; }
        public static double Sum(int a, int b)
        {
            return a + b;
        }
    }




    public interface ITestInterface
    {
        void TestMethod1(int a, int b);
    }



    //sealed class
    //can be initialized/ by new keyword
    //can not be inherited
    //can inherit
    //can  implement  interfaces

    public sealed class LivingCell
    {
        public static int Number { get; set; }
        public string Goup { get; set; }

        public void Breath()
        {
            Console.WriteLine("Breathing");
        }
    }


    #endregion
}





