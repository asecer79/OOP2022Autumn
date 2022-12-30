using System.Threading;

namespace W13
{
    public class Program
    {
       

        private static async Task Main()
       // private static void Main()
        {

            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            var account = new Account(1000, "Aydın");

            //for (int i = 0; i < 10; i++)
            //{
            //    account.Deposit(100);
            //    account.Withdraw(100);
            //}

            //account.CurrentBalance();


            //for (int i = 0; i < 150; i++)
            //{
            //    new Thread(() =>
            //    {
            //        account.Deposit(100);

            //    }).Start();

            //    new Thread(() =>
            //    {
            //        account.Withdraw(100);

            //    }).Start();
            //}

            //account.CurrentBalance();

            //var m = 10;
            //Parallel.For(1, m, (i) =>
            //{
            //    account.Deposit(100); //asynchronous
            //    account.Withdraw(100);//asynchronous
            //});  //synchronous 



            //account.CurrentBalance();
            //Parallel.Invoke(
            //() =>
            //{
            //    account.Deposit(100);
            //}, () =>
            //{
            //    account.Withdraw(100);
            //}, () =>
            //{
            //    account.Deposit(100);
            //});

            //account.CurrentBalance();

            //Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);

            //var task1 = Task.Run(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread1: " + Thread.CurrentThread.ManagedThreadId);
            //     Console.WriteLine("Parallel executed Code 1");
            // });

            //var task2 = Task.Run(() =>
            // {
            //     //Thread.Sleep(15000);
            //     Console.WriteLine("Thread2: " + Thread.CurrentThread.ManagedThreadId);
            //     Console.WriteLine("Parallel executed Code 2");
            //     //Task.Delay(15000);
            // });

            //Task.WaitAll(task1, task2);

            //int result=  CountAsync(10).Result;
            CountAsync(100,cancellationTokenSource,cancellationToken);
            CountAsync(1000, cancellationTokenSource, cancellationToken);
            CountAsync(2000, cancellationTokenSource, cancellationToken);
            CountAsync(2000, cancellationTokenSource, cancellationToken);
            CountAsync(2000, cancellationTokenSource, cancellationToken);
            CountAsync(2000, cancellationTokenSource, cancellationToken);

            Console.WriteLine("EOF Code 3");

            Thread.Sleep(30000);

        }


        public static async Task<int> CountAsync(int n,CancellationTokenSource cancellationToken,CancellationToken token)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i%101==0)
                    {
                        cancellationToken.Cancel();
                    }
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Ended: "+ i);
                        return;
                    }
                    Thread .Sleep(new Random().Next(50, 150));
                    Console.WriteLine(i);
                }
            });
            
            return 1;
        } 
    }

    //thread safe class
    //thread synchronization with Mutex class

    class Account
    {
        private readonly Semaphore _semaphore;
        public Account(double balance, string owner)
        {
            Balance = balance;
            Owner = owner;
            // _semaphore = new Semaphore(initialCount:5,maximumCount:5); //semaphore
            _semaphore = new Semaphore(initialCount: 1, maximumCount: 1); //mutex
        }
        public string Owner { get; set; }

        public double Balance { get; set; }

        private readonly object _locker = new object();

        public void Withdraw(double amount)
        {
            _semaphore.WaitOne();
            Thread.Sleep(100);
            Balance = Balance - amount;
            _semaphore.Release();
        }

        public void Deposit(double amount)
        {
            _semaphore.WaitOne();
            Thread.Sleep(300);
            Balance = Balance + amount;
            _semaphore.Release();
        }

        public void CurrentBalance()
        {
            Console.WriteLine("Current Balance: " + Balance);
        }

    }


    //thread safe class
    //thread synchronization with Mutex class

    //class Account
    //{
    //    private readonly Mutex _mutex;
    //    public Account(double balance, string owner)
    //    {
    //        Balance = balance;
    //        Owner = owner;
    //        _mutex = new Mutex(true);//caution....
    //    }
    //    public string Owner { get; set; }

    //    public double Balance { get; set; }

    //    private readonly object _locker = new object();

    //    public void Withdraw(double amount)
    //    {
    //        _mutex.WaitOne();
    //        Thread.Sleep(1);
    //        Balance = Balance - amount;
    //        _mutex.ReleaseMutex();
    //    }

    //    public void Deposit(double amount)
    //    {
    //        _mutex.WaitOne();
    //        Thread.Sleep(2);
    //        Balance = Balance + amount;
    //        _mutex.ReleaseMutex();
    //    }

    //    public void CurrentBalance()
    //    {
    //        Console.WriteLine("Current Balance: " + Balance);
    //    }

    //}

    //thread safe class
    //thread synchronization with lock keyword
    //class Account
    //{
    //    public Account(double balance, string owner)
    //    {
    //        Balance = balance;
    //        Owner = owner;
    //    }
    //    public string Owner { get; set; }

    //    public double Balance { get; set; }

    //    private readonly object _locker = new object();

    //    public void Withdraw(double amount)
    //    {
    //        lock (_locker)
    //        {
    //            Thread.Sleep(10);
    //            Balance = Balance - amount;
    //        }
    //    }

    //    public void Deposit(double amount)
    //    {
    //        lock (_locker)
    //        {
    //            Thread.Sleep(1000);
    //            Balance = Balance + amount;
    //        }
    //    }

    //    public void CurrentBalance()
    //    {
    //        Console.WriteLine("Current Balance: " + Balance);
    //    }

    //}

    ////thread unsafe class
    //class Account
    //{
    //    public Account(double balance, string owner)
    //    {
    //        Balance = balance;
    //        Owner = owner;
    //    }
    //    public string Owner { get; set; }

    //    public double Balance { get; set; }

    //    public void Withdraw(double amount)
    //    {
    //        Thread.Sleep(10);
    //        Balance = Balance - amount;
    //    }

    //    public void Deposit(double amount)
    //    {
    //        Thread.Sleep(1000);
    //        Balance = Balance + amount;
    //    }

    //    public void CurrentBalance()
    //    {
    //        Console.WriteLine("Current Balance: " + Balance);
    //    }

    //}
}



