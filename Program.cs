using System;
using System.Threading;



namespace Vitaliy.Helloworld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string greeting1 = "Hello, Dude....",
            greeting2 = "I know where you are now",
            greeting3 = "And I have smth for you....",
            greeting4 = "Liza gives you and Olya best regards";
            foreach (char symbol in greeting1)
            {
                Console.Write(symbol);
                Thread.Sleep(200);
            }
            Thread.Sleep(5000);
            Console.Clear();
            foreach (char symbol in greeting2)
            {
                Console.Write(symbol);
                Thread.Sleep(200);
            }
            Thread.Sleep(5000);
            Console.Clear();
            foreach (char symbol in greeting3)
            {
                Console.Write(symbol);
                Thread.Sleep(200);
            }
            Thread.Sleep(5000);
            Console.Clear();
            foreach (char symbol in greeting4)
            {
                Console.Write(symbol);
                Thread.Sleep(200);
            }
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}