using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace PizzaStore_v1
{
    class Order
    {
        #region Instancefields

        private Customer _customer;
        private Pizza _pizza;
        private ExtraTopping _extraTopping1;
        private ExtraTopping _extraTopping2;
        private ExtraTopping _extraTopping3;

        private double _tax = 0.1;
        private int _delivery = 40;


        #endregion

        #region Constructor

        public Order(Customer customer, Pizza pizza, ExtraTopping extraTopping1, ExtraTopping extraTopping2, ExtraTopping extraTopping3)
        {
            _customer = customer;
            _pizza = pizza;
            _extraTopping1 = extraTopping1;
            _extraTopping2 = extraTopping2;
            _extraTopping3 = extraTopping3;
        }

        #endregion

        #region Properties

        public double Tax
        {
            get
            {
               return _tax * 100;

            }
        }
        

        public int Delivery
        {
            get { return _delivery; }
        }

        #endregion

        #region Methods

        public string FormatString4()
        {
            return "{0,-15} {1,-24} {2,-25} {3,26}"; //Metode til at formatere en WriteLine med 4 felter
        }

        public string FormatString2() //Metode til at formatere en WriteLine med 2 felter
        {
            return "{0,-15} {1,-24}";
        }
        public override string ToString()
        {
            return $"Customer info:\n{_customer}\n\nPizza info:\n{_pizza}\n\nExtra topping info:\nExtra topping 1:\n{_extraTopping1}\n\nExtra topping 2:\n{_extraTopping2}\n\nExtra topping 3:\n{_extraTopping3}";
        }
        public static string FormatHeadlineString()
        {
            return "{0,-40} {1,-45} {2,-40}";
        }

        public double CalculateTotal()
        {
            double totalPrice = (_pizza.Price + _extraTopping1.Price + _extraTopping2.Price + _extraTopping3.Price + Delivery) * (_tax + 1);
            return totalPrice;
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"{FormatHeadlineString()}", "Customer info:", "Order info:", "Price:");
            Console.WriteLine($"{FormatString4()}", "Full Name:", $"{_customer.FullName}", $"{_pizza.Name}", $"{_pizza.Price}kr");
            Console.WriteLine($"{FormatString4()}", "Address:", $"{_customer.Address}", $"   -{_extraTopping1.Name}", $"{_extraTopping1.Price}kr");
            Console.WriteLine($"{FormatString4()}", "City:", $"{_customer.PostalCode}, {_customer.CityName}", $"   -{_extraTopping2.Name}", $"{_extraTopping2.Price}kr");
            Console.WriteLine($"{FormatString4()}", "Email:", $"{_customer.Email}", $"   -{_extraTopping3.Name}", $"{_extraTopping3.Price}kr");
            Console.WriteLine($"{FormatString2()}", "Phonenumber:", $"{_customer.Phonenumber}");
            Console.WriteLine();
            Console.WriteLine("{0,93}", $"Total (incl. {Delivery} kr");
            Console.WriteLine("{0,93}", $" delivery and {Tax}% tax):");
            Console.WriteLine("{0,93}", $"____");
            Console.WriteLine("{0,93}", $"{CalculateTotal()}");
        }

        #endregion
    }
}
