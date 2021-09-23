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
            this.Stundenlohn = stundenlohn > 0 ? stundenlohn : 1;
            this.Stundenzahl = stundenzahl >= 0 ? stundenzahl : 0;
        }

        private double stundenlohn = 1;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Only positive values are allowed");
                }

                stundenzahl = value;
            }
        }

        public override double GetBrutto()
        {
            return Stundenzahl * Stundenlohn;
        }
    }
}