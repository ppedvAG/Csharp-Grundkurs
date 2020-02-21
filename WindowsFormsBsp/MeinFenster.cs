using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBsp
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class MeinFenster : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public MeinFenster()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet (-> sollte immer die erste Funktion sein, welche
            ///der Konstruktor aufruft
            InitializeComponent();

            //Hinzufügen eines Eintrags zur Combobox
            CbbPersonen.Items.Add("Jürgen");

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            BtnKlickMich.Click += timer1_Tick;
        }


        //Click-Methoden, der einzelnen Buttons
        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
            //Ändern der Hintergrundfarbe des Fensters
            this.BackColor = Color.HotPink;

            //Verschieben des Buttons um 10 Pixel nach rechts
            this.BtnKlickMich.Left += 10;

            //Cast des aufrufenden Objekts zum Button und Verschieben des Buttons um 10 Pixel nach rechts
            (sender as Button).Left += 10;

            //Prüfung, ob die Checkbox abgehakt ist
            if (ChbHakMichAb.Checked)
                MessageBox.Show("Checkbox ist abgehakt");

            //Ausgabe des markierten Elements in der Combobox als String in einer MessageBox
            //(? ist Null-Prüfung: ToString wird nur ausgeführt, wenn SelectedItem belegt ist)
            MessageBox.Show(CbbPersonen.SelectedItem?.ToString());
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schließen des aktuellen Fensters
            this.Close();

            //Beenden der kompletten Applikation
            Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziierung des neuen Fensters
            MeinFenster neuesFenster = new MeinFenster();

            //Manipuation des Fenstertitels
            neuesFenster.Text = "2. Fenster";

            //Öffnen des Fensters als gleichberechtigtes Fenster
            //neuesFenster.Show();

            //Öffnen des neuen Fensters als Dialogfenster (verbietet Zugriff auf alle anderen Fenster)
            neuesFenster.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Anzeigen einer MessageBox mit Prüfung, welcher Button geklickt wurde
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Aber nicht mehr lange...");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bewegen der ComboBox um 1 Pixel nach unten
            CbbPersonen.Top++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Prüfung, ob der Timer läuft
            if (timer1.Enabled)
                //Stoppen des Timers
                timer1.Stop();
            else
                //Starten des Timers
                timer1.Start();
        }
    }
}
