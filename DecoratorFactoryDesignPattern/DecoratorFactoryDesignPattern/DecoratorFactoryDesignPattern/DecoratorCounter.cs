using DecoratorFactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a type");
            Console.WriteLine("1. Lower");
            Console.WriteLine("2. Upper");
            Console.WriteLine("3. Both");
            string type = Console.ReadLine();

            int option = 0;
            Console.WriteLine("Please enter a value");
            string t = Console.ReadLine();
            int value = Convert.ToInt32(t);

            Counter c = new CounterFactory().GetCounter(value,type);

            while (option != 4)
            {
                Console.WriteLine("\nChoose Option\n");
                Console.WriteLine("================\n");
                Console.WriteLine("1. Increment");
                Console.WriteLine("2. Decrement");
                Console.WriteLine("3. Read Value");
                Console.WriteLine("4. Exit");

                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    c.increment();

                }
                else if (option == 2)
                {
                    c.decrement();
                }
                else if (option == 3)
                {
                    int res = c.read_value();
                    Console.WriteLine("Val=" + res);
                }

                else if (option == 4)
                {
                    Console.WriteLine("Exit");
                }
            }
        }
    }
}
