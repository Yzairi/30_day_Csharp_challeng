using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_day_c__chalenge.Day3
{
    public class Building
    {
        public string Address { get; set; }

        public Building()
        {
            
        }
        public Building(string address)
        {
            Address = address;
        }
        
        public override  string ToString()
        {
            return $"L'adresse du bâtiment c'est :{Address}";
        }
    }
}
