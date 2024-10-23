using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> paiements;

        public Utilisateur(string nom)
        {
            Nom = nom;
            paiements = new List<Paiement>();
        }

        public void AjouterPaiement(Paiement paiement)
        {
            paiements.Add(paiement);
        }

        public void AfficherInfo()
        {
            Console.WriteLine($"Informations sur les paiements de l'utilisateur : {Nom}");
            foreach (var paiement in paiements)
            {
                paiement.Afficherdetails();
            }
        }
    }
}
