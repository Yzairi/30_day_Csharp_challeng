using _30_day_c__chalenge.Day1;
using _30_day_c__chalenge.Day3;
using _30_day_c__chalenge.Day5;

namespace _30_day_c__chalenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 1
            //var ferrary = new Car(new DateOnly(2024, 01, 01), "Avetador", 200000);
            //ferrary.Start();
            //ferrary.Accelerate();
            //Console.WriteLine(ferrary.ToString());
            //var ram = new Truck(new DateOnly(2024, 01, 01), "BIIIP BIIIP !!!", 125000);
            //ram.Start();
            //ram.Accelerate();
            //Console.WriteLine(ram);

            //Day 3
            //Exo1
            //Building B2 = new Building("Paris");
            //Console.WriteLine(B2);

            //House M2 = new("Bordeaux", 3);
            //Console.WriteLine(M2);

            //Exo2
            //Article article = new Article("Bois", "RER", 100, 200);
            //Console.WriteLine(article.CalculerPrixTTC());
            //article.AfficherArticle();

            //Exo5
            Complexe complexe1 = new(5, 7);
            Complexe complexe2 = new(2, 8);
            Complexe complexe3 = new(3, 9);
            Complexe complexe4 = new(4, 10);
            Complexe complexe5 = new(5, 11);
            Console.WriteLine();
            Console.WriteLine(complexe1.ToString());
            Console.WriteLine(complexe2.ToString());
            Console.WriteLine();
            Complexe.Plus(complexe1, complexe2);
            Complexe.Minus(complexe1, complexe2);
        }
    }
}