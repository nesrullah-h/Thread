using System;
using System.Threading;

namespace Threadd
{
    internal class Program
    {
        public int Count { get; set; }
        private Object obj = new Object();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread thread1 = new Thread(p.Increase);
            Thread thread2 = new Thread(p.Deccrease);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine(p.Count);

             
        }
        void Increase()
        {
                for (int i = 0; i < 10000; i++)
                {
                lock (obj)
                {
                    Count++;
                }
                }
        } 
        void Deccrease()
        {
                for (int i = 0; i < 10000; i++)
                {
                lock (obj)
                {
                    Count--;
                }
            }
        }





          
        //{
        //    Thread thread1 = new Thread(Loop1);
        //    Thread thread2 = new Thread(Loop2);
        //    thread1.Start();
        //    thread2.Start(); 
        //    thread1.Join();
        //    thread2.Join();
        //    Console.WriteLine("Console ishledi");
        //}
        //static void Loop1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"Loop 1 {i}");
        //    }
        //}
        //static void Loop2()
        //{
        //    for (int i = 100; i < 200; i++)
        //    {
        //        Console.WriteLine($"Loop 2 {i}");
        //    }
        //}
    }
}
