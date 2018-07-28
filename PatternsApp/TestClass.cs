using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsApp
{
    public class TestClass:IDisposable
    {
        static TestClass()
        {
            Console.WriteLine("static constructor");
        }

        public TestClass()
        {
            Console.WriteLine("constructor");
        }

        public TestClass(string name)
        {
            Console.WriteLine("constructor "+ name);
        }

        ~TestClass()
        {
            Console.WriteLine("destructor");
        }

        public virtual void Dispose()
        {
            Console.WriteLine("dispose");
        }
    }

    public class TestClassB : TestClass
    {
        static TestClassB()
        {
            Console.WriteLine("static constructor B");
        }

        public TestClassB(string name) : base(name)
        {
            Console.WriteLine("constructor B " + name);
        }

        public override void Dispose()
        {
            //base.Dispose();
            Console.WriteLine("dispose B");
            
        }

        
    }
}
