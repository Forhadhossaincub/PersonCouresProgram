﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCoures.Entities
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name , string address, DateTime dob)
        {
            this.Name = name;
            this.Address = address;
            this.DateOfBirth = dob;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public abstract int Age();

    }
}
