using System;
using System.Threading;

namespace Vitaliy.Helloworld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string greeting_1 = "Hello, Dude....",
            greeting_2 = "I know where are you now",
            greeting_3 = "And I have smth for you....",
            greeting_4 = "Liza gives you and Olya best regards";
            foreach (char greeting in greeting_1)
            {
                Console.Write(greeting);
                Thread.Sleep(300);
            }
            Thread.Sleep(5000);
            Console.Clear();
            foreach (char greeting in greeting_2)
            {
                Console.Write(greeting);
                Thread.Sleep(300);
            }
            foreach (char greeting in greeting_3)
            {
                Console.Write(greeting);
                Thread.Sleep(300);
            }
            Thread.Sleep(5000);
            Console.Clear();
            foreach (char greeting in greeting_4)
            {
                Console.Write(greeting);
                Thread.Sleep(300);
            }
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}