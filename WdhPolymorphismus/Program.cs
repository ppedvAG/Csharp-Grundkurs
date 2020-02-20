using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdhPolymorphismus
{
    abstract class Tier
    {
        public int AnzahlBeine { get; set; }
        public string Name { get; set; }

        public Tier(string name, int anzB)
        {
            this.AnzahlBeine = anzB;
            this.Name = name;
        }

        public abstract void Fressen();
    }

    class Hund : Tier
    {
        public string Fellfarbe { get; set; }
        public Hund(string name, string fellFarbe) : base(name, 4)
        {
            this.Fellfarbe = fellFarbe;
        }

        public override void Fressen()
        {
            Console.WriteLine("Der Hund frisst ein Stück Fleisch.");
        }
    }

    class Meise : Tier, IFlugfähig
    {
        public string Federfarbe { get; set; }
        public int FlügelAnzahl { get; set; }

        public Meise(string name, string federFarbe) : base(name, 2)
        {
            this.Federfarbe = federFarbe;
            this.FlügelAnzahl = 2;
        }

        public override void Fressen()
        {
            Console.WriteLine("Die Meise pickt Körner");
        }

        public void Abheben()
        {
            Console.WriteLine("Dies Meise fliegt jetzt.");
        }
    }

    class Flugzeug : IFlugfähig
    {
        public int MaxFlughöhe { get; set; }
        public int FlügelAnzahl { get; set; }

        public Flugzeug(int flügelAnzahl)
        {
            this.MaxFlughöhe = 9999;
            this.FlügelAnzahl = flügelAnzahl;
        }

        public void Abheben()
        {
            Console.WriteLine("Das Flugzeug ist in der Luft");
        }
    }

    interface IFlugfähig
    {
        int FlügelAnzahl { get; set; }

        void Abheben();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("Bello", "Braun");
            Console.WriteLine(hund1.Name + ": " + hund1.Fellfarbe);

            Meise meise1 = new Meise("Tschiep", "Blau");
            Console.WriteLine(meise1.Name + ": " + meise1.Federfarbe);

            BenenneUm(hund1, "Hasso");
            Console.WriteLine(hund1.Name + ": " + hund1.Fellfarbe);

            Tier tier1 = meise1;

            if (tier1 is Hund)
                ((Hund)tier1).Fellfarbe = "Schwarz";
            else
            {
                (tier1 as Meise).FlügelAnzahl = 1;
            }

            Flugzeug fz1 = new Flugzeug(4);

            Absturz(meise1);
            Absturz(fz1);

            IFlugfähig flugfähig = meise1;

            Absturz(flugfähig);

            hund1.Fressen();
            meise1.Fressen();

            tier1.Fressen();


            Console.ReadKey();
        }

        static void BenenneUm(Tier tier, string neuerName)
        {
            tier.Name = neuerName;

            if (tier is Hund)
                ((Hund)tier).Fellfarbe = "Schwarz";
        }

        static void Absturz(IFlugfähig flugfähigesObjekt)
        {
            flugfähigesObjekt.FlügelAnzahl--;
        }
    }
}
