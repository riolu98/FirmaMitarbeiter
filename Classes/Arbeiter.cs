using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirmaMitarbeiter.Classes
{
    public class Arbeiter : Mitarbeiter
    {
        public Arbeiter() { }

        public Arbeiter(string firstName, string lastName, double stundenlohn, int stundenzahl)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Stundenlohn = stundenlohn;
            this.Stundenzahl = stundenzahl;
        }

        private double stundenlohn = 0;
        public double Stundenlohn
        {
            get { return stundenlohn; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Only values greater than zero are allowed");
                }

                stundenlohn = value;
            }
        }

        private int stundenzahl = 0;
        public int Stundenzahl
        {
            get { return stundenzahl; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Only values greater than zero are allowed");
                }

                stundenzahl = value;
            }
        }
    }
}