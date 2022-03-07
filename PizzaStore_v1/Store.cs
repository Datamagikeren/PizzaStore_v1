using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore_v1
{
    public static class Store
    {
        #region Methods

        public static void PrintLine()
        {
            Console.WriteLine("_____________________________________________________________________________________________");
        }

        public static void Wait2()
        {
            System.Threading.Thread.Sleep(2000); // Makes console wait 2 seconds
        }
        public static void Wait1()
        {
            System.Threading.Thread.Sleep(1000); // Makes console wait 1 second
        }
        public static void Wait3()
        {
            System.Threading.Thread.Sleep(3000); // Makes console wait 1 second
        }
        public static void Wait250()
        {
            System.Threading.Thread.Sleep(250); // Makes console wait 500 milliseconds
        }
        public static void Start()
        {
            #region Objekter

            #region CustomerObjekter

            Customer c1 = new Customer("Lasse", "Kristensen", "Lysalleen", 558, "Roskilde", 4000, "lasse4040@gmail.com", "22549485");
            Customer c2 = new Customer("Jonas", "Christophersen", "Merkurvej", 3, "Jyllinge", 4000, "hamlover98@yahoo.com", "55349534");
            Customer c3 = new Customer("Johanne", "Bentsen", "Hovedvej", 9, "Tune", 4030, "johanne@bentsen.dk", "34025211");

            #endregion

            #region PizzaObjekter

            Pizza p1 = new Pizza("Hawaii", 99);
            Pizza p2 = new Pizza("Mushroom", 109);
            Pizza p3 = new Pizza("Magherita", 89);

            #endregion

            #region ExtraToppingObjekter

            ExtraTopping et1 = new ExtraTopping("Add extra cheese", 10);
            ExtraTopping et2 = new ExtraTopping("Add extra ham", 15);
            ExtraTopping et3 = new ExtraTopping("Add Gold leaves", 400);
            ExtraTopping et4 = new ExtraTopping("None", 0);

            #endregion

            #region Orderobjekter

            Order o1 = new Order(c1, p3, et1, et4, et4);
            Order o2 = new Order(c2, p1, et1, et2, et2);
            Order o3 = new Order(c3, p2, et3, et3, et3);


            #endregion
            #endregion

            #region Program

            System.Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write($"Welcome to the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PizzaStore Order App");
            Console.ResetColor();
            Console.WriteLine("© ");
            Console.WriteLine("Press 'enter' to login...");
            Console.ReadKey();
            Console.WriteLine("Please wait while we log you in...");
            Console.WriteLine();
            Console.WriteLine("Username: ");
            Console.Write("Password: ");
            Wait3();
            Console.SetCursorPosition(10, Console.CursorTop - 1);
            Console.Write("B");
            Wait250();
            Console.Write("I");
            Wait250();
            Console.Write("G");
            Wait250();
            Console.Write("M");
            Wait250();
            Console.Write("A");
            Wait250();
            Console.Write("M");
            Wait250();
            Console.Write("A");

            Console.WriteLine();
            Wait3();
            Console.SetCursorPosition(10, Console.CursorTop - 0);
            Console.Write("h");
            Wait250();
            Console.Write("e");
            Wait250();
            Console.Write("j");
            Wait250();
            Console.Write("1");
            Wait250();
            Console.Write("2");
            Wait250();
            Console.WriteLine("3");
            Wait2();
            Console.WriteLine("...");
            Wait3();
            Console.Clear();
            Console.WriteLine("Login successful!");
            Wait1();
            Console.Clear();
            Console.WriteLine("Current status: CLOSED");
            Console.WriteLine("Press 'enter' to CHANGE current status...");
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.ReadKey();
            Console.WriteLine("Current status: OPEN  ");
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.WriteLine("Waiting for orders...");
            Wait2();
            Wait2();
            PrintLine();
            Console.WriteLine();
            o1.PrintOrderInfo();
            Console.WriteLine();
            PrintLine();
            Wait2();
            Console.WriteLine();
            o2.PrintOrderInfo();
            Console.WriteLine();
            PrintLine();
            Wait2();
            Wait1();
            Console.WriteLine();
            o3.PrintOrderInfo();
            Console.WriteLine();
            PrintLine();
            Console.WriteLine("Maximum of 3 orders reached. Closing for orders. Complete previous orders to open again");
            Console.WriteLine("Current status: CLOSED");


            #endregion


        }

        #endregion
    }
}
