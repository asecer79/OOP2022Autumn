

using System.Runtime.InteropServices;
using System.Xml;

namespace W02
{

    //outer scope/ namespace level

    class Program
    {

        //global scope for this class
        static void Main(string[] args)
        {

            /*

                  //local scope
                  int a = 2;

                  if (true)
                  {
                      Console.WriteLine(a);
                      //local scope
                  }
                  //data types specified during compile time
                  //explicit variable definition
                  //type-safe definition
                  int age1 = 15;
                  double salary1 = 1500.89;
                  string name1 = "Ahmet";


                  //data types specified during compile time
                  //implicit variable definition
                  //type-safe definition
                  var age2 = 15;
                  var salary2 = 1500.98;
                  var name2 = "Ahmet";


                  //data types specified during runt-time
                  //dynamic variable definition
                  //non type-safe definition
                  dynamic age3 = 15;
                  dynamic salary3 = 1500.59;
                  dynamic name3 = "Ahmet";


                  //age1 = "sadsad";  //error
                  //age2 = "sdfsdf";  //error

                  //age3 = "Aydin";

                  //dynamic num1 = 1212; //c#
                  //num1 = 15616; // js, python etc


                  int age4; // variable and may change anywhere
                  age4 = 4;
                  Console.WriteLine(age4);

                  const int age5 = 15; //constant may not change after its assignment.
                  //age5 = 34;




                  MyClass myClass = new MyClass();

                 // MyClass.salary = 12.34;//error  //call constant from outside

                 //single line comment
                 // myClass.age1 = 34;//err

                  //block comments



                 //overflow
                 // 4 byte                6byte



                 int num1 =Convert.ToInt32("132156135264516514654651656"); //problematic assignment 

             */

            /*Console.WriteLine(myClass.age1);
            Console.WriteLine(myClass.name);
            Console.WriteLine(MyClass.salary);
            */


            //Console.WriteLine("Write an integer and press enter: "); //output method

            //int number1 =Convert.ToInt32(Console.ReadLine()); //Console.ReadLine() input method



            //type safety languages
            //left side type >= right side type  //if not overflow may occurs

            //int num1 = 1512;

            ////type of size(double) >= type of size (int)
            //double num2 = 25.565656; //implicit type conversion
            //                         //type of size(int) < type of size (double)
            //                         //int num3 = num2; //error

            ////explicit type conversion
            //int num3 = (int)num2; //explicit cast operation converts double to integer.
            //int num4 = Convert.ToInt32(num2);//explicit conversion via helper class
            //int num5 = Convert.ToInt32(num3);//explicit conversion via helper class

            //Console.WriteLine($"{num2}:  {num2.GetType()}");
            //Console.WriteLine($"{num3}:  {num3.GetType()}");
            //Console.WriteLine($"{num4}:  {num4.GetType()}");


            //operators // binary operator  2 ops
            //variable type and nam  = (assignment operator)     left operand       arithmetic operator        right operand     
            //int result               =                             36                   +                           79;


            //unary operators  ++,  --, !      1 op
            //int num6 = 36;
            //++num6;
            //num6--;

            ////ternary operators  3         3 ops
            //int isCorrect = (1 < 3) ? 1 : 0;


            ////as and is operators
            //// if (1.GetType() == typeof(int))
            //if ("ahmet" is int)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //int? num = 123;

            //double? numX = num as double?; //as used for reference types !!!!! 

            //var x = '\0';
            //string x = null;

            //if (x == null)
            //{
            //    Console.WriteLine("yess");
            //}


            //primitive types cannot be null as a default
            //reference type can be null
            //null safety lang c#
            //int x = null; //primitive or value type give us error

            // int? z = null; //? will permit us to define value type as nullable type

            // string  y = null; //reference type

            //array

            //int[] a = new int[] { 1, 2, 3 };
            //int[,] b = new int[,] {{ 1, 2, 3 }, 
            //                        { 1, 2, 3 }};

            ////int is primitive type but int[]  is reference type

            //// ???  char[] != string ???? 
            //char[] name1= new char[] { 'a', 'y', 'd','ı','n' };
            //name1[1] = 'Y';


            //string name2 = "aydın"; //immutable
            //name2[1] = 'Y'; //error
           // name2 = "aYdın"; //no error
           
            //char[] is mutable ref object but string is immutable (mutable is a concept that can be changed some thing)



            //control statements
            //if (1<2)
            //{
            //    Console.WriteLine("yes");
            //    if (3>-2)
            //    {
            //        Console.WriteLine("yess");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //int age = 25;

            //switch (age)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    case 4:
            //        Console.WriteLine("4");
            //        break;

            //    default: Console.WriteLine("default");
            //        break;
                    
            //}

            //string isOlder = age > 50 ? "Yes" : "No"; //conditional if, ternary operation

            Loops.Run();

        }
    }

    class MyClass
    {

        public string name;

        public readonly int age1;

        public MyClass()
        {
            age1 = 15;

        }

        public const double salary = 1566.98;
    }

}


