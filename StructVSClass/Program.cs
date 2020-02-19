using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVSClass
{
    class PersonC
    {
        public string name;
        public int alter;

        public PersonC(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    struct PersonS
    {
        public string name;
        public int alter;

        public PersonS(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }


    class Program
    {
        public static void Altern(PersonC person)
        {
            person.alter++;
        }

        public static void Altern(PersonS person)
        {
            person.alter++;
        }

        public static void Altern(ref PersonS person)
        {
            person.alter++;
        }

        static void Main(string[] args)
        {
            PersonC KlassenPerson = new PersonC("Anna", 29);
            PersonS StructPerson = new PersonS("Otto", 29);

            Console.WriteLine($"{KlassenPerson.name}: {KlassenPerson.alter}");
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            Altern(KlassenPerson);
            Altern(StructPerson);

            Console.WriteLine($"{KlassenPerson.name}: {KlassenPerson.alter}");
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            Altern(ref StructPerson);
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            Console.ReadKey();
        }
    }
}
