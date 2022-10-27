﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public interface ICustomer
    {
        int Discount { get;set; }
        int OrderTotal { get; set; }
        string GreetMessage { get; set; }
        bool IsPlatinum { get; set; }
        string GreetAndCombineNames(string firstName, string lastName);
    }

    public class Customer
    {
        public int Discount = 15;
        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }
        public bool IsPlatinum { get; set; }
        public Customer()
        {
            IsPlatinum = false;
        }
        public string GreetAndCombineNames(string firstName, string lastName)
        {
            if ( string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }

            GreetMessage = $"Hello, {firstName} {lastName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}