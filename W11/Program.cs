namespace W11
{

    class Program
    {
        static void Main(string[] args)
        {
            ////main thread
            //Console.WriteLine("Line 1");
            //Thread.Sleep(2000);
            //Thread.CurrentThread.Name = "Main Thread";
            //Console.WriteLine(Thread.CurrentThread.Name);
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //Thread.Sleep(3000);
            //Console.WriteLine("Line 2");
            //// eof main thread

            //Method1("Main");

            //  Console.WriteLine("Main thread started");
            //  Console.WriteLine("Main Thread ID: "+ Thread.CurrentThread.ManagedThreadId);
            //  Thread thread1 = new Thread(Method1);

            //  //  thread1.IsBackground = true;
            //  thread1.Start("Th-1");
            //  thread1.Priority = ThreadPriority.Lowest;
            //  // thread1.Join(5000);

            //  Thread thread2 = new Thread(Method1);
            // // thread2.IsBackground = true;
            //  thread2.Start("Th-2");
            //  thread2.Priority = ThreadPriority.Highest;
            // // thread2.Join(5000);

            //  // Method1();
            //  // Thread.Sleep(50000);
            //  Console.WriteLine("last op finished");

            ////  Console.ReadLine();

            int t = 1;
            ThreadPool.SetMinThreads(t, t);
            ThreadPool.SetMaxThreads(t, t);

            WaitCallback wcb = new WaitCallback(Login);

            int userCount = 150000;

            for (int i = 0; i < userCount; i++)
            {
                ThreadPool.QueueUserWorkItem(wcb,i);
               // Thread.Sleep(15);
            }

           // Thread.Sleep(10000000);
           Console.ReadLine();

        }

        static void Login(object userName)
        {
            //logic...
            
            Console.WriteLine($"ThreadId: {Thread.CurrentThread.ManagedThreadId}, message: {userName}, Logged in...");
            Thread.Sleep(500);

        }

        static void Method1(object message)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(1, 5000));
                Console.WriteLine($"ThreadId: {Thread.CurrentThread.ManagedThreadId}, message: {message}, value: {i}");
            }
        }
    }
}

