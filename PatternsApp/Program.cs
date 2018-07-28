using System;

namespace PatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (TestClassB t = new TestClassB("hej"))
            {

            }

            Console.ReadKey();

        }
    }
}
