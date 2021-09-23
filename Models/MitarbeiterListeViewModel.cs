using System.Collections.Generic;

namespace FirmaMitarbeiter.Models
{
    public class MitarbeiterListeViewModel
    {
        public MitarbeiterListeViewModel()
        {
            this.MitarbeiterListe = new List<MitarbeiterViewModel>();

            this.MitarbeiterListe.Add(new MitarbeiterViewModel("Jonathan", "Schubert", 2800));
            this.MitarbeiterListe.Add(new MitarbeiterViewModel("Sven", "Schmidtlein", 2900));
            this.MitarbeiterListe.Add(new MitarbeiterViewModel("Haik", "Rafaeljan", 3000));

        }
        public List<MitarbeiterViewModel> MitarbeiterListe { get; set; }
    }
}