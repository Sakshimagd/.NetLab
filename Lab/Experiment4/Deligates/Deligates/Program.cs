//single cast delegate

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace DelegatesDemo
//{
//    class Program
//    {
//        static void Display(string S)
//        {
//            Console.WriteLine("single cast delegate");
//            Console.WriteLine("My Name is :" + S);
//        }
//        delegate void X(string a);
//        static void Main(string[] args)
//        {
//            X objD = new X(Display);
//            objD("Rathrola Prem Kumar");
//            Console.Read();
//        }
//    }
//}



//multi cast deligate

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace DelegatesDemo
//{
//    class Program
//    {
//        public void Add(int x, int y)
//        {
//            Console.WriteLine("multi cast deligate");
//            Console.WriteLine("Sum is:" + (x + y));
//        }
//        public void Substract(int x, int y)
//        {
//            Console.WriteLine("Difference is:" + (x - y));
//        }
//    }
//    public delegate void MultiCastDelegate(int a, int b);
//    class ClsDelegate
//    {
//        static void Main()
//        {
//            Program obj1 = new Program();
//            MultiCastDelegate objD = new MultiCastDelegate(obj1.Add);
//            objD += obj1.Substract;
//            objD(40, 10);
//            objD -= obj1.Substract;
//            objD(50, 10);
//            Console.ReadLine();
//        }
//    }
//}

//using arrow function
//using System;

//class Program
//{
//    public static int Multiply(int a, int b)
//    {
//        return a * b;
//    }

//    static void Main(string[] args)
//    {
//        int result1 = Multiply(4, 5);
//        Console.WriteLine("Using Method: " + result1);

//        Func<int, int, int> multiplyLambda = (a, b) => a * b;

//        int result2 = multiplyLambda(4, 5);
//        Console.WriteLine("Using Lambda: " + result2);

//        Console.ReadLine(); // keeps console open
//    }
//}


//sort list using lambda expression
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 1, 9, 3, 7 };

//        // Sort in ascending order using lambda
//        numbers.Sort((a, b) => a.CompareTo(b));
//        Console.WriteLine("Ascending Order:");
//        foreach (var num in numbers)
//        {
//            Console.WriteLine(num);
//        }

//        // Sort in descending order using lambda
//        numbers.Sort((a, b) => b.CompareTo(a));

//        Console.WriteLine("\nDescending Order:");
//        foreach (var num in numbers)
//        {
//            Console.WriteLine(num);
//        }

//        Console.ReadLine();
//    }
//}


//where we use deligates and lambda expressions in industries or companies

//Delegates and lambda expressions are foundational to modern .NET development (C#, VB.NET) and are used extensively across various industries to make code more modular,
//flexible, and concise. They are primarily used as type-safe function pointers and for passing behavior as parameters

//1. LINQ and Data Processing (Everywhere) 
//The most common use of lambda expressions is with Language Integrated Query (LINQ), used to process collections in any enterprise application

//2.Event - Driven Programming(GUI, Web, IoT)
//Delegates are the backbone of events in frameworks like WPF, WinForms, Blazor, and Xamarin

//3.Asynchronous Programming and Callbacks (API, Networking) 
//Used to handle non-blocking operations, such as calling an external API or downloading a file. 


//What is LINQ queries
//LINQ(Language Integrated Query) is a feature in C# that provides a way to query and manipulate data from different sources such as collections, databases, XML or objects.
//It integrates query capabilities directly into the C# language using a set of query operators and extension methods.

