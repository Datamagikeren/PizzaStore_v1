using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore_v1
{
    class Customer
    {
        #region Instancefields

        private string _name;
        private string _surname;
        private string _streetName;
        private int _streetNumber;
        private int _postalCode;
        private string _cityName;
        private string _email;
        private string _phonenumber;
        #endregion

        #region Constructor

        public Customer(string name, string surname, string streetName, int streetNumber, string cityName, int postalCode, string email, string phonenumber)
        {
            _name = name;
            _surname = surname;
            _streetName = streetName;
            _streetNumber = streetNumber;
            _postalCode = postalCode;
            _cityName = cityName;
            _email = email;
            _phonenumber = phonenumber;
        }
        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public string Surname
        {
            get { return _surname; }
        }

        public string StreetName
        {
            get { return _streetName; }
        }

        public int StreetNumber
        {
            get { return _streetNumber; }
        }

        public int PostalCode
        {
            get { return _postalCode; }
        }

        public string CityName
        {
            get { return _cityName; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Phonenumber
        {
            get { return _phonenumber; }
        }

        public string Address
        {
            get { return $"{StreetName} {StreetNumber}"; }
        }

        public string FullName
        {
            get { return $"{Name} {Surname}"; }
        }

        public string PostalAndCity
        {
            get { return $"{_postalCode} {_cityName}"; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Full Name: {FullName}\nAddress: {Address}\nEmail: {Email}\nPhonenumber: {Phonenumber}\nCity: {PostalAndCity}";
        }

        #endregion
    }
}
