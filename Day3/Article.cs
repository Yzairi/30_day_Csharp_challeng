namespace _30_day_c__chalenge.Day3
{
    internal class Article
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int PrixHt { get; set; }
        public int TauxTVA { get; set; }

        public Article()
        {

        }
        public Article(string reference, string designation)
        {
            Reference = reference;
            Designation = designation;
        }
        public Article(string reference, string designation, int prixHt, int pricTva)
        {
            Reference = reference;
            Designation = designation;
            PrixHt = prixHt;
            TauxTVA = pricTva;
        }

        public int CalculerPrixTTC()
        {
            return PrixHt + (PrixHt * TauxTVA / 100);
        }
        public void AfficherArticle()
        { 
            Console.WriteLine($"Reference : {Reference}\n Designation: {Designation}\n PrixHt : {PrixHt}\n TauxTVA : {TauxTVA}");
        }
    }
}
