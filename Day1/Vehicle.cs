namespace _30_day_c__chalenge.Day1
{
    public abstract class Vehicle
    {
        private static int _registrationNumber { get; set; }
        private DateOnly _year { get; set; }
        private string _model { get; set; }
        private double _price { get; set; }

        public Vehicle(DateOnly year, string model, int price)
        {
            ++_registrationNumber;
            _year = year;
            _model = model;
            _price = price;
        }
        public abstract void Start();

        public abstract void Accelerate();

        public void Tostring()
        {
            Console.WriteLine($"Le numero de matriculationest {_registrationNumber}, de l’année {_year}, du modèle {_model} et du prix :{_price} $");
        }
    }
}
