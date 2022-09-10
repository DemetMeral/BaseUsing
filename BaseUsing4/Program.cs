using System;

namespace BaseUsing4
{
    class Program
    {
        static void Main(string[] args)
        {
            A nesne = new A(5);

            Console.ReadLine();
        }


        class A : B
        {
            public A()
            {
                Console.WriteLine("A");
            }

            public A(int x)
            {
                Console.WriteLine("A"+x);
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
