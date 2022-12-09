using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace W10
{
    public class MyOperations
    {
        //action generic delegate / lambda expression (=>) functions / 
        //single line lambda expressions
        //public Action<int, int> Sum1 = (i, j) => Console.WriteLine(i + j);
        //public Func<int, int, int> Sum2 = (i, j) => i + j;

        //multiline lambda expressions
        //public Action<int, int> Sum1 = (i, j) =>
        //{
        //    //do any logics
        //    //lines ..
        //    Console.WriteLine(i + j);
        //};
        //public Func<int, int, int> Sum2 = (i, j) =>
        //{
        //    //do any logics
        //    //lines ..
        //    return i + j;
        //};

        public MyOperations()
        {
            Sum1a = Sum1;
            Sum2a=Sum2;
        }

        public Action<int, int> Sum1a;
        public Func<int, int,int> Sum2a;

        public void Sum1(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        public int Sum2(int i, int j)
        {
            return i + j;
        }
    }
}
