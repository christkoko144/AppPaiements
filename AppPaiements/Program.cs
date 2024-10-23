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
    }
}