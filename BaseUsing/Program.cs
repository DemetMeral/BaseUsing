using System;

namespace BaseUsing
{
    class Program
    {
        static void Main(string[] args)
        {

            A nesne = new A();
            nesne.Yaz();
            Console.ReadLine();
        }
    }

    class A:B
    {
    public void Yaz()
        {
            Console.WriteLine("A:B");

        }
    }

    class B
    {
        public void Yaz()
        {

            Console.WriteLine("B");
        }


    }
}
