using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //Ein INTERFACE zwingt die implementierenden Klassen bestimmte Methoden und Eigenschaften zu implementieren, so dass diesbezüglich 
    ///eine Typsicherheit besteht.
    public interface IBewegbar
    {
        //In einem Interface sind keine Zugriffsmodifier erlaubt
        int AnzahlRäder { get; set; }

        //Es werden (wie bei abstarkten Methoden) nur die Methodenköpfe geschrieben. Der Rest wird in den implementierenden Klassen hinzugefügt
        void Crash();
    }
}
