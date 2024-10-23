using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }
        public Paypal(double montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }

        public override void Afficherdetails()
        {
            Console.WriteLine($"Le paiement a hauteur de ${Montant} effectuer par {Courriel} est pour {Description}");
        }
    }
}
