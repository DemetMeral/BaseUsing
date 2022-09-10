using System;

namespace BaseUsingExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            A nesne = new A();
           
            Console.ReadLine();
        }


        class A : B
        {
            public A()
            {
                Console.WriteLine("A");
            }
        }

        class B
        {
            public B()
            {
                Console.WriteLine("B");
            }

        }
    }
}
