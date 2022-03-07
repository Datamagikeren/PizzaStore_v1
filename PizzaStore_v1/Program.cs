using System;
using System.Security.Cryptography.X509Certificates;

namespace PizzaStore_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            Store.Start();
            Console.ReadKey();
        }
    }
}
