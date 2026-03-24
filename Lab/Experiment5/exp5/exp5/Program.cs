using System;
using System.Threading;

namespace EXP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchronous Start");

            Method1();
            Method2();

            Console.WriteLine("Synchronous End");
        }

        static void Method1()
        {
            Console.WriteLine("Method1 Start");
            Thread.Sleep(3000);
            Console.WriteLine("Method1 End");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 Start");
            Thread.Sleep(2000);
            Console.WriteLine("Method2 End");
        }
    }
}

//Asynchronous version

//using System;
//using System.Threading.Tasks;

//namespace EXP05
//{
//    internal class Program
//    {
//        static async Task Main(string[] args)
//        {
//            Console.WriteLine("Async Start");

//            Task t1 = Method1Async();
//            Task t2 = Method2Async();

//            await t1;
//            await t2;

//            Console.WriteLine("Async End");
//        }

//        static async Task Method1Async()
//        {
//            Console.WriteLine("Method1 Start");
//            await Task.Delay(3000); // non-blocking
//            Console.WriteLine("Method1 End");
//        }

//        static async Task Method2Async()
//        {
//            Console.WriteLine("Method2 Start");
//            await Task.Delay(2000); // non-blocking
//            Console.WriteLine("Method2 End");
//        }
//    }
//}