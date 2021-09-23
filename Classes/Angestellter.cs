using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirmaMitarbeiter.Classes
{
    public class Angestellter : Mitarbeiter
    {
        public Angestellter() { }

        public Angestellter(string firstName, string lastName, double bruttoGehalt)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BruttoGehalt = bruttoGehalt;
        }

        private double bruttoGehalt = 0;
        public double BruttoGehalt
        {
            get { return bruttoGehalt; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Only values greater than zero are allowed");
                }

                bruttoGehalt = value;
            }
        }
    }
}