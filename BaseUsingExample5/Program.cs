using System;

namespace BaseUsingExample5
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

            public A(int x):base(x )
            {

               
                Console.WriteLine("A" + x);
            }
        }

        class B
        {
            public B()
            {
                Console.WriteLine("B");
            }
            public B( int x)
            {
                Console.WriteLine("B" + x);
            }

        }
    }
}
