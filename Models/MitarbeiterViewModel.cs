using System.ComponentModel;

namespace FirmaMitarbeiter.Models
{
    public class MitarbeiterViewModel
    {
        public MitarbeiterViewModel()
        {

        }

        public MitarbeiterViewModel(string firstName, string lastName, double bruttoGehalt)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BruttoGehalt = bruttoGehalt;
        }

        [DisplayName("Vorname")]
        public string FirstName { get; set; }

        [DisplayName("Nachname")]
        public string LastName { get; set; }

        [DisplayName("Bruttogehalt")]
        public double BruttoGehalt { get; set; }

    }
}