namespace _30_day_c__chalenge.Day1
{
    internal class Truck : Vehicle
    {
        public Truck(DateOnly year, string model, int price) : base(year, model, price)
        {
        }

        public override void Start()
        {
            Console.WriteLine("the truck Start !!");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Speed += 10Km/H");
        }
    }
}
