using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
        ///vorher definiert werden.
        public delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            //Ausführung der Delegate-Variablen
            int erg = delegateVariable(5, 12);
            Console.WriteLine(erg);

            //Neuzuweisung der Variable (Kurzschreibweise)
            delegateVariable = Subtrahiere;

            erg = delegateVariable(5, 12);
            Console.WriteLine(erg);

            //Zuweisung einer zweiten Methode zur Delegate-Variablen
            delegateVariable += Addiere;

            //Bei Ausführung einer Delegate-Variablen werden alle referenzierten Methoden in der Reihenfolge ihrer Zuweisung ausgeführt.
            ///Nur die letzte Methode gibt einen Rückgabewert zurück
            erg = delegateVariable(5, 12);
            Console.WriteLine(erg);

            //Erstellen und Ausgabe einer Liste der in der Variablen gespeicherten Methode
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }

            //Löschen einer Referenz aus der Variablen
            delegateVariable -= Subtrahiere;

            //Löschen sämtlicher Referenzen aus der Variablen
            delegateVariable = null;


            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;

            Console.WriteLine(meinFunc(45,78));

            //Übergabe einer Methode an eine andere Methode
            FühreAus(meinFunc);
            FühreAus(Addiere);

            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren
            List<string> Städteliste = new List<string>() { "München", "Berlin", "Frankfurt", "Hamburg" };

            //Vergleichsbeispiel mit Übergabe einer anderen (nicht anonymen) Methode
            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            //Übergabe der Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("H");
                });
            Console.WriteLine(gefundeneStadt);


            //Übergabe der anonymen Methode in LAMBDA-Schreibweise (Lang und Kurz)
            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith("H"); });
            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith("H"));

            //Weiteres Bsp für die Übergabe einer anonymen Methode in Lambda (Sortierung der Einträge nach dem ersten Buchstaben)
            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            //weiteres Bsp der Lambda-Schreibweise (Methode empfängt zwei int und gibt deren Summe als int zurück)
            meinFunc = delegate (int a, int b) { return a + b; };
            meinFunc = (a, b) => a + b;

            Console.ReadKey();

        }

        //Bsp-Methode zur Übergabe an eine Liste
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(Func<int, int, int> auszuführendeMethode)
        {
            auszuführendeMethode(12, 78);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        //Bsp-Methoden zur Demonstration der Delegate-Funktionalität
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addieren");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahieren");
            return a - b;
        }

    }
}
