﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public abstract class Customer
    {
        //Fields
        private string name;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructor
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
