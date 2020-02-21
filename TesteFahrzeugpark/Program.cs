using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Durch 'using Fahrzeugpark' kann ein Schnellzugriff auf den Namespace 'Fahrzeugpark' erfolgen
//Damit 'Fahrzeugpark' verwendet werden kann muss diese Bibliothek in den Refernezen angemeldet werden.
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Modul04: OOP
            ////Instanzierung der Fahrzeuge

            ////volle Pfadangabe bei Objekt/Variablenaufruf
            //Fahrzeugpark.Fahrzeug fz1 = new Fahrzeugpark.Fahrzeug("BMW", 250);

            ////Benutzung der using-Anweisung
            //Fahrzeug fz2 = new Fahrzeug("VW", 190);

            //Aufruf des paraeterlosen Konstruktors
            //Fahrzeug fz3 = new Fahrzeug();

            ////Ausgabe von fz1
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");

            ////Veränderung des Namens von fz1
            //fz1.Name = "Opel";
            ////Ausgabe der Fahrzeugeigenschaften (fz1 wurde verändert, fz2 nicht)
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");
            //Console.WriteLine(fz2.Name + ": " + fz2.MaxGeschwindigkeit + "km/h");

            ////Ausgabe der BeschreibeMich-Methode von fz1
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Neuzuweisung der fz2-Variable auf Objekt in fz1 (beide Variablen zeigen auf dasselbe Objekt)
            //fz2 = fz1;

            ////manueller Aufruf der GarbageCollection
            //GC.Collect();
            #endregion

            #region Lab04: Fahrzeug_Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Modul05: Vererbung

            ////Bsp-Objekt-Instanzierung
            //PKW pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);

            ////Aufruf der ToString()-Methode
            //Console.WriteLine(pkw1);
            ////Aufruf der Hupe()-Methode
            //pkw1.Hupe();

            ////Ausgabe von statischer Eingenschaft/Methode
            //Console.WriteLine(Fahrzeug.AnzahlErstellterFahrzeuge);
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Lab05: PKW-, Schiff- und Flugzeug-Klasse

            ////Instanzierung eines Bsp-PKWs
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());
            //pkw1.Hupe();

            ////Instanzierung eines Bsp-Schiffs
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());
            //schiff1.Hupe();

            ////Instanzierung eines Bsp-Flugzeugs
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());
            //flugzeug1.Hupe();

            ////Ausgabe der statischen Methode der Fahrzeugklasse
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Modul06: Interfaces und Polymorphismus
            ////Instanzierung von Bsp-Objekt
            //PKW pkw1 = new PKW("BMW", 190, 23000, 4);
            ////Aufruf der Interface-Methode
            //pkw1.Crash();

            ////Zuweisung neuer Variablen (anderer Variablentyp) mit dem PKW-Objekt
            ////-> Variablentyp definiert 'Sichtbarkeit' der Eigenschaften
            //Fahrzeug fz1 = pkw1;
            //IBewegbar bewegbaresObjekt = pkw1;

            ////BSP: Variablentyp = Fahrzeug | Laufzeittyp (= Typ des Objekts) = PKW
            //Fahrzeug fz2 = new PKW("VW", 190, 25000, 3);

            ////Prüdung, ob in Fahrzeug-Variable ein PKW-Objekt liegt...
            //if (fz2 is PKW)
            //{
            //    //... wenn ja, dann Cast in PKW und Zuweisung zu PKW-Variable
            //    PKW pkw2 = (PKW)fz2;
            //}

            ////Aufruf der BSP-Funktion (s.u.)
            //MontiereNeuesRad(pkw1);
            #endregion

            #region Lab06: IBeladbar

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            #region Modul07: Generische Listen
            ////Deklaration und Initialisierung einer Liste von Strings
            //List<string> Städteliste = new List<string>();

            ////Hinzufügen von Listeneinträgen
            //Städteliste.Add("Berlin");
            //Städteliste.Add("Köln");
            //Städteliste.Add("Hamburg");
            //Städteliste.Add("Nürnberg");
            //Städteliste.Add("München");

            ////Ausgabe der Länge der Liste
            //Console.WriteLine(Städteliste.Count);

            ////Ausgabe der 3. Listenposition
            //Console.WriteLine(Städteliste[2]);

            ////Manipulation der 3. Listenposition
            //Staedteliste[2] = "Dresden";
            //Console.WriteLine(Staedteliste[2]);

            ////Schleife über die Liste
            //foreach (var item in Städteliste)
            //{
            //    Console.WriteLine(item);
            //}

            ////Löschen des Eintrags 'Köln' (Nachfolgende Einträge rücken nach oben)
            //Staedteliste.Remove("Köln");

            ////Bsp für Fahrzeug-Liste
            //List<Fahrzeug> Fahrzeugliste = new List<Fahrzeug>();

            //Fahrzeugliste.Add(new PKW("BMW", 190, 23000, 4));
            //Fahrzeugliste.Add(new PKW("BMW", 190, 23000, 4));
            //Fahrzeugliste.Add(new PKW("BMW", 190, 23000, 4));
            //Fahrzeugliste.Add(new PKW("BMW", 190, 23000, 4));
            //Fahrzeugliste.Add(new PKW("BMW", 190, 23000, 4));

            //foreach (var item in Fahrzeugliste)
            //{
            //    Console.WriteLine(item);
            //}

            //Fahrzeugliste.RemoveAt(3);


            ////Deklaration und Initialisierung eines Dictionarys (Key: Int, Value: String)
            //Dictionary<int, string> Dict = new Dictionary<int, string>();

            ////Hinzufügen von Dictionary-Einträgen
            //Dict.Add(1, "Hallo");
            //Dict.Add(202, "Ciao");
            //Dict.Add(3185, "Hi");

            ////Ausgabe des Eintrags mit Key '202'
            //Console.WriteLine(Dict[202]);

            ////Deklaration und Initialisierung eines Hastables + Erstellung und Abruf von Einträgen (nicht-genereisches Dictionary nach dem Hash-Speicherprinzip)
            //Hashtable ht = new Hashtable();
            //ht.Add("Hallo", 450);
            //ht.Add(78.5, new PKW("VW", 260, 250020, 4));
            //Console.WriteLine(ht["Hallo"]);

            ////Schleife über Dictionary
            //foreach (var item in Dictionary1)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value);
            //}

            ////Deklaration und Initialisierung eines Hastables + Erstellung und Abruf von Einträgen (nicht-genereisches Dictionary nach dem Hash-Speicherprinzip)
            //Hashtable ht = new Hashtable();
            //ht.Add("Hallo", 450);
            //ht.Add(78.5, new PKW("VW", 260, 250020, 4));
            //Console.WriteLine(ht["Hallo"]);

            ////Deklaration und Initialisierung eines HashSets (generische Liste nach dem Hash-Speicherprinzip)
            //HashSet<int> hs = new HashSet<int>();
            //hs.Add(23); 
            #endregion

            #region Lab07 ZufälligeFahrzeuglisten

            ////Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            //Random generator = new Random();
            //Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            ////Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            //int AnzahlFZs = 10000;

            ////Schleife zur zufälligen Befüllung von Queue und Stack
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Würfeln einer zufälligen Zahl im Switch
            //    switch (generator.Next(1, 4))
            //    {
            //        //Erzeugung von Objekten je nach zufälliger Zahl
            //        case 1:
            //            fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
            //            fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
            //            break;
            //        case 2:
            //            fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //            fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //            break;
            //        case 3:
            //            fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
            //            fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
            //            break;
            //    }
            //}

            ////Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
            //    if (fzQueue.Peek() is IBeladbar)
            //    {
            //        //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
            //        ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
            //        //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //    }
            //    else
            //    {
            //        //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
            //        fzQueue.Dequeue();
            //        fzStack.Pop();
            //    }
            //}

            ////Programmpause
            //Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            ////Schleife zur Ausgabe des Dictionaries
            //foreach (var item in fzDict)
            //{
            //    Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            //}

            #endregion

            //Erstellung von Bsp-Objekten
            PKW pkw1 = PKW.ErzeugeZufälligenPKW("");
            PKW pkw2 = PKW.ErzeugeZufälligenPKW("");

            pkw2.Name = pkw1.Name;

            Console.WriteLine(pkw1.Name);
            Console.WriteLine(pkw2.Name);

            //Bsp für die Verwendung der in der Fahrzeug-Klasse definierten Operatoren
            Console.WriteLine(pkw1 == pkw2);
            Console.WriteLine(pkw1 != pkw2);

            Flugzeug flug1 = new Flugzeug("Boing", 800, 30000000, 9999);

            //Bsp für die Verwendung von IEnumerable
            foreach (var item in flug1)
            {
                Console.WriteLine(item);
            }

            //Bsp für die Verwendung der Indexer-Property
            Console.WriteLine(flug1[2]);

            Random gene = new Random();

            //Bsp für die Verwendung einer Erweiterungsmethode (s.u.)
            Console.WriteLine(gene.NextInclusive(1,5));

            Console.ReadKey();
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

        //BSP-Funktion: Polymorphismus (Modul 06)
        //Funktion empfängt ein beliebiges Objekt, dass das Interface IBewegbar implementiert hat
        public static void MontiereNeuesRad(IBewegbar bewegbar)
        {
            //Manipulation der durch Interface definierten Eigenschaft
            bewegbar.AnzahlRäder++;

            //Test, ob Objekt ein Flugzeug ist...
            if (bewegbar is Flugzeug)
                //...wenn ja, dann Cast in Flugzeug und Manipulation der Flugzeug-Spezifischen Eigenschaft MaxFlughöhe
                ((Flugzeug)bewegbar).MaxFlughöhe -= 100;
        }
    }
}


static class Hilfsmethoden
{
    //Mittels des THIS-Stichworts in der Parameterübergabe kann eine Methode als Erweiterungsmethode einer Klasse definiert
    //werden. Diese muss in einer statischen Klasse beschrieben werden und wird dann als Teil der zugeordneten Klasse betrachtet.
    public static int NextInclusive(this Random generator, int untergrenze, int obergrenze)
    {
        return generator.Next(untergrenze, obergrenze + 1);
    }
}
