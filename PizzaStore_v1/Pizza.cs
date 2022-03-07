using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore_v1
{
    class Pizza
    {
        #region Instancefields

        private string _name;
        private double _price;
        #endregion

        #region Constructor

        public Pizza(string name, double price)
        {
            _name = name;
            _price = price;
        }
        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }
        public double Price
        {
            get { return _price; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Name of pizza: {Name}\nPrice of pizza: {Price}";
        }

        #endregion
    }
}
