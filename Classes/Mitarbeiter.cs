﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirmaMitarbeiter.Classes
{
    public abstract class Mitarbeiter
    {
        public Mitarbeiter()
        {

        }

        public Mitarbeiter(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}