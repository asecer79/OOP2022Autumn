using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace W03
{
    public class Methods
    {
        //private int a = 5;
        //private int b = 5;

        //notype sum(no type) //not common usage, in some routine long process can be used.
        //public void Sum()
        //{
        //    Console.WriteLine($"a + b = {a+b}");
        //}

        //type sum(no type) // more common usage
        //public int Sum()
        //{
        //   // Console.WriteLine($"a + b = {a + b}");
        //   return a + b;
        //}


        //no type sum(int a, int b)
        //public void Sum(int a, int b) // used more than previous one
        //{
        //    Console.WriteLine($"a + b = {a + b}");
        //}



        //type sum (int a, int b) //the most common one

        //public int Sum(int a, int b)
        //{
        //  //  Console.WriteLine($"a + b = {a + b}");
        //  return a + b;
        //}


        //optional params

        //public void Sum(int a=0, int b = 0, int c=0, int d = 0)
        //{
        //    var result = a + b + c + d;

        //    Console.WriteLine($"result = {result}");
        //   ;
        //}

        //public void CalculateNetPrice(double amount, double interestRate=0.18)
        //{
        //    var netValue =amount + amount * interestRate;
        //    Console.WriteLine($"Amount is {amount}, Interest Rate is {interestRate}, NetPrice = {netValue}");
            
        //}


        //named parameters

        //no need any extra ops.

        //arbitrary number of parameters
        //public void Sum(params int[] numbers )
        //{
        //    var sum = 0;

        //    foreach (var item in numbers)
        //    {
        //        sum += item;
        //    }

        //    Console.WriteLine($"Sum = {sum}");
        //}



        //method overloading, using same name but different method signature

        public void Sum(int a, int b)
        {
            Console.WriteLine($"a+b = {a+b}");
        }

        public void Sum(double a, double b)
        {
            Console.WriteLine($"a+b = {a + b}");
        }

        public string Sum(double a, double b, double c)
        {
            return  $"a + b +c = {a + b + c}";
        }
    }
}
