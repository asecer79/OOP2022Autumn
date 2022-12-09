
using System.Collections;
using System.Runtime.Intrinsics.Arm;


namespace W10
{
    //method signature/ prototype  
    public delegate T MyMath<T>(T x, T y); //where T: struct; //generic delegate 

    class Program
    {

        static void Main(string[] args)
        {
            //MyMath<float> mySum = Sum;
            //Console.WriteLine(mySum(1,2));
            //MyMath<int> mySubtract = Subtract;
            //Console.WriteLine(mySubtract(1, 2));

            //DoProcess<float>(Sum, 1, 4); //callback method as parameter
            //DoProcess<double>(Divide, 1.0, 4);

            #region Singlecast Delegates execution

            //var myFunc = MethodSelector(2);
            //           Console.WriteLine(myFunc(10,2));
            //           Console.WriteLine(MethodSelector(-1)(10,5));

            #endregion


            #region Multicast Delegates execution

            // MyMath<int> methods = Sum;
            // methods += Product; //methods binding
            // methods += Divide;
            // methods -= Product;
            // methods.Invoke(3, 1);

            #endregion


            //MyOperations ops = new MyOperations();
            //ops.Sum1(2,3);
            //Console.WriteLine(ops.Sum2(2,3));


            //Func<int, int, int> Average = (x, y) =>
            //{

            //    //logics

            //    return (x + y) / 2;

            //};

            //DoProcess2(Average, 2, 6);

            //DoProcess2((x, y) =>
            //{
            //    return (x + y) / 2;
            //}, 5, 5);

            //DoProcess((x, y) =>
            //{
            //    //Console.WriteLine(x^2);
            //    //logic 
            //    //aaaa
            //    return x*x;
            //},1,2);


            #region Event Handling

            DatabaseHelper dbHelper = new DatabaseHelper();

           
            dbHelper.ConnectEvent += DbHelper_ConnectEvent;
            dbHelper.Connect();

            dbHelper.InsertEvent += (sender, eventArgs) =>
            {
                Console.WriteLine("InsertEvent triggered");
            };

            dbHelper.Insert();
      
            #endregion


        }

        private static void DbHelper_ConnectEvent(object sender, EventArgs e)
        {
            Console.WriteLine("ConnectEvent triggered");
            //some logics
        }

        static void DoProcess2<T>(Func<T, T, T> myFun, T x, T y)
        {
            Console.WriteLine(myFun(x, y));
        }

        //methods as input parameters

        //methods as parameters of another method
        static void DoProcess<T>(MyMath<T> processType, T x, T y)
        {
            Console.WriteLine(processType(x, y));
        }

        //methods that returns another methods
        static MyMath<int> MethodSelector(int selectedMethod)
        {
            if (selectedMethod == 1)
            {
                return Sum;
            }
            else if (selectedMethod == 2)
            {
                return Divide;
            }
            else if (selectedMethod == 3)
            {
                return Subtract;
            }
            else
            {
                return Product;
            }
        }

        static int Sum(int x, int y)
        {
            Console.WriteLine("Sum(int,int) executed");
            return x + y;
        }
        static float Sum(float x, float y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static double Divide(double x, double y)
        {
            return x / y;
        }

        static float Divide(float x, float y)
        {
            return x / y;
        }

        static int Divide(int x, int y)
        {
            Console.WriteLine("Divide(int,int) executed");
            return x / y;
        }


        static int Product(int x, int y)
        {
            Console.WriteLine("Product(int,int) executed");
            return x * y;
        }

    }
}




