using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _30_day_c__chalenge.Day3
{
    public class House : Building
    {
        public int NbPieces { get; set; }

        public House(): base()
        {
            
        }
        public House(string address , int nbPieces) : base(address) 
        {
            Address = address;
            NbPieces = nbPieces;
        }

        public override string ToString()
        {
            return $"L'adresse de la maison c'est :{Address}, et elle a {NbPieces} pieces";
        }
    }
}
