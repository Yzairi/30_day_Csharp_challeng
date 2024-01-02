using _30_day_c__chalenge.Day1;

namespace _30_day_c__chalenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 1
            var ferrary = new Car(new DateOnly(2024, 01, 01), "Avetador", 200000);
            ferrary.Start();
            ferrary.Accelerate();
            Console.WriteLine(ferrary.ToString());
            var ram = new Truck(new DateOnly(2024, 01, 01), "BIIIP BIIIP !!!", 125000);
            ram.Start();
            ram.Accelerate();
            Console.WriteLine(ram.ToString());
        }
    }
}