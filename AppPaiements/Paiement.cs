using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        public double Montant { get; set; }
        public string Description { get; set; }

        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;
        }

        public virtual void Afficherdetails()
        {
            Console.WriteLine($"le paiement a {Description} est de ${Montant}");
        }
    }
}
