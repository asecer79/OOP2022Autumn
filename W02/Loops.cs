using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02
{
    //loops
    public class Loops
    {
        public static void Run()
        {
            //standard loops
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
                //for (int j = 0; j < UPPER; j++) //nested loops
                //{
                //    for (int k = 0; k < UPPER; k++)
                //    {
                //        for (int l = 0; l < UPPER; l++)
                //        {

                //        }
                //    }
                //}
            }
            Console.WriteLine(sum); //55

            sum = 0;
            int counter = 0;
            while (counter <= 10)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum); //55

            sum = 0;
            counter = 0;
            while (++counter <= 10)
            {
                sum += counter;
            }

            Console.WriteLine(sum); //55

            sum = 0;
            counter = 0;

            do
            {
                sum += counter;
            } while (++counter <= 10);

            Console.WriteLine(sum); //55

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sum = 0;
            foreach (var item in ages)
            {
                sum += item;
            }
            Console.WriteLine(sum); //55


            //non standard loops
            sum = 0;
            counter = 0;

            gelBuraya: //goto label //not recommended

            sum += ++counter;

            if (counter<10)
            {
               goto gelBuraya; 
            }

            Console.WriteLine(sum); //55

            Console.WriteLine(Sum(10)); //55




            //infinite loops
            int condition = 150;
            int cnt = 0;
            for (;;)
            {
                Console.WriteLine("working");
                cnt++;
                if (cnt>condition)
                {
                    break;
                }

                //does not reached
            }

            Console.WriteLine("Infinite loop stopped");

        }

        static int Sum(int n)//recursive function
        {
            if (n==0)
            {
                return 0;
            }
            else
            {
                return n + Sum(n - 1);
            }
        }
    }
}
