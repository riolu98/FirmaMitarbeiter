using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirmaMitarbeiter.Classes
{
    public class Arbeiter : Mitarbeiter
    {
        public Arbeiter()
        {

        }

        double StundenLohn { get; set; } = 0;

        int Stundenzahl { get; set; } = 0;
    }
}