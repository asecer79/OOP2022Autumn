using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03
{
    public class StringDataType
    {
        public static void Run()
        {
            //  //difference between string and primitive types
            //  int number = 123;//primitive type/value type/ as default cannot be null
            ////  number = null;


            //  string name = "Aydın"; //reference type/ can be null// string is immutable

            //  name = "Aydıns";


            //  A myObject = new A(-1,-2);//reference type and is mutable

            //  //myObject.a = -1;
            //  //myObject.b = -2;

            //   myObject = null;

            //Console.WriteLine("Hello");


            char[] name1 = { 'A', 'y', 'd', 'ı', 'n' }; //reference type, mutable
            name1[1] = 'w';


            string name2 = "Aydın"; //reference type, immutable
                                    // name2[1] = 'W'; //immutable produce error
            name2 = "Aywın"; //creates a new copy of object and old one destructed by G.C


            Console.WriteLine(name2.Length);
            Console.WriteLine(name2.ToUpper());
            Console.WriteLine(name2.ToLower());
            Console.WriteLine(name2.Contains("yw"));
            Console.WriteLine(name2.Split("w"));
            Console.WriteLine(name2.Trim());


            //string interpolation

            string a = "Word";
            int b = 26546;

            string c = "Ankara";

            var formattedData = a + b + " Extra word"; //old and not good
            Console.WriteLine(formattedData);

            formattedData = string.Format("{0}{1} Extra word", a, b); //finer
            Console.WriteLine(formattedData);

            formattedData = $"{a}{b} Extra word";  //best way to interpolate strings
            Console.WriteLine(formattedData);

        }
    }

    class A
    {
        public A(int _a, int _b)
        {
            a = _a;
            b = _b;

        }
        private int a = 4;
        private int b = 5;

    }
}
