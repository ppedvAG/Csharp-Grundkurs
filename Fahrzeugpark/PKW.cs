using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class PKW : Fahrzeug
    {
        public int AnzahlTüren { get; set; }

        public PKW(string name, int maxG, decimal preis, int anzTüren) : base(name, maxG, preis)
        {
            this.AnzahlTüren = anzTüren;
        }

        public override string BeschreibeMich()
        {
            return "Der PKW " + base.BeschreibeMich() + $" Er hat {this.AnzahlTüren} Türen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("Trööt");
        }
    }
}
