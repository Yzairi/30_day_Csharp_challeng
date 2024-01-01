namespace _30_day_c__chalenge.Day1
{
    internal class Car : Vehicle
    {
        public Car(DateOnly year, string model, int price) : base(year, model, price)
        {
        }
        public override void Start()
        {
            Console.WriteLine("the car Start !!");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Speed += 20Km/H");
        }
    }
}
