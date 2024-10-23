using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(300, "epicerie", 4534);
        CarteCredit achat2 = new CarteCredit(40, "Mcdo", 4509);
        CarteCredit achat3 = new CarteCredit(1500, "Prada", 4534);

        achat1.Afficherdetails();
        achat2.Afficherdetails();
        achat3.Afficherdetails();

        Paypal transaction1 = new Paypal(500, "Stok'x", "jean@gmail.com");
        Paypal transaction2 = new Paypal(1000, "Apple", "christ@gmail.com");

        transaction1.Afficherdetails();
        transaction2.Afficherdetails();

        Utilisateur utilisateur = new("christ");
        utilisateur.AjouterPaiement(new Paypal(300, "zara", "yvan@gmail.com"));
        utilisateur.AjouterPaiement(new CarteCredit(400, "epicerie", 4567));

        utilisateur.AfficherInfo();

    }
}