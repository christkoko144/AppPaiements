using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int Carte) : base(montant, description)
        {
            NumeroCarte = Carte;
        }

        public override void Afficherdetails()
        {
            Console.WriteLine($"La carte de credit {NumeroCarte} a ete debiter de ${Montant} pour {Description}");
        }
    }
}
