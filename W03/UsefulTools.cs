using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03
{
    public class UsefulTools
    {
        public static void Run()
        {

            #region Random ex


            //Random random = new Random();


            ////RollDice




            //for (int i = 0; i < 100; i++)
            //{
            //    int[] rolDice = {random.Next(1,7),random.Next(1,7) };
            //     Console.WriteLine($"Roll1: {rolDice[0]}");
            //     Console.WriteLine($"Roll2: {rolDice[1]}");

            //Console.WriteLine($"******************");
            //}



            //RollDice




            //for (int i = 0; i < 100; i++)
            //{
            //    int[] rolDice = { new Random().Next(1, 7), new Random().Next(1, 7) };
            //    Console.WriteLine($"Roll1: {rolDice[0]}");
            //    Console.WriteLine($"Roll2: {rolDice[1]}");

            //    Console.WriteLine($"******************");
            //}


            #endregion

            #region DateTime ops


            //DateTime dateTime;

            //Console.WriteLine(DateTime.MaxValue);
            //Console.WriteLine(DateTime.MinValue);

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);

            //Console.WriteLine(DateTime.Now.AddDays(-152).DayOfWeek);

            //TimeSpan timeSpan = DateTime.Now - new DateTime(1979, 2, 19);

            //Console.WriteLine(timeSpan.TotalDays);
            //Console.WriteLine(timeSpan.Duration());


            #endregion

            #region MathOPs

            //Console.WriteLine(Math.Sqrt(100));
            //Console.WriteLine(Math.Pow(2,5));
            //Console.WriteLine(Math.Sin(30 * Math.PI/180));



            #endregion

            #region Convert Class

            Console.Write("Enter number: ");

            var userInput = Console.ReadLine();

            // var userInputConverted = Convert.ToDouble(userInput);

            var userInputConverted = double.Parse(userInput);


            Console.WriteLine($"Entered number: {userInput},  and Pow({userInput},3) = {Math.Pow(userInputConverted, 3)}");

            #endregion

        }
    }
}
