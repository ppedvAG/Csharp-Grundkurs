using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl auch PKW
    //Mittels des Interfaces IEnumerable kann eine Klasse dazu befähigt werden, die foreach-Schleife zu unterstützen. Dieses
    //Interface zwingt die implementierenden Klassen dazu die Methode GetEnumerator zu definieren, welche durch die Schleife
    //aufgerufen wird.
    public class Flugzeug : Fahrzeug, IBewegbar, IEnumerable
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }
        public List<string> Passagierliste { get; set; }

        //Mittels der unten stehenden Indexer-Property kann eine Klasse befähigt werden, die Index-Scheibweise von z.B. den Array zu übernehmen
        //(Für Verwendung siehe TesteFahrzeugpark)
        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 8;

            Passagierliste = new List<string>() { "Anna", "Otto", "Hannes" };
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $"Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("BiepBiep");
        }

        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;
        }

        //Durch IEnumerable verlangte Methode (Für Verwendung siehe TesteFahrzeugpark)
        public IEnumerator GetEnumerator()
        {
            foreach (var item in Passagierliste)
            {
                //Mittels des YIELD-Stichworts kann in jedem Durchlauf der Schleife einen Wert zurückgeben werden, 
                //ohne dass danach die Methode abgebrochen wird
                yield return item;
            }
        }
    }

}
