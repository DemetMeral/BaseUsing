using System;

namespace BaseUsingExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            A nesne = new A();
            nesne.Yaz();
            Console.ReadLine();
        }


        class A : B
        {
            public void Yaz()
            {
                /// B clasını  çağırmak için oluşturuldu.
                base.Yaz();
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
}
