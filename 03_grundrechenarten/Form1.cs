using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_Nr._3
{
    public partial class Form1 : Form
    {
        // Variablen deklarieren und intiliaisieren
        double zahl1 = 0, zahl2 = 0, ergebnis = 0;
        // Wird bei der Unterscheidung zwischen gültigen und ungültigen Werten helfen
        bool errorcheck = false, msgboxcheck = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rad_geteilt_CheckedChanged(object sender, EventArgs e)
        {
            // Text für Radiobuttons festlegen
            lbl_operator.Text = "/";
        }

        private void txt_zahl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rad_plus_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operator.Text = "+";
        }

        private void rad_minus_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operator.Text = "-";
        }

        private void rad_mal_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operator.Text = "*";
        }

        private void btn_nochmal_Click(object sender, EventArgs e)
        {
            // Fast alle Anzeigen werden eingeblendet
            rad_plus.Visible = true;
            rad_minus.Visible = true;
            rad_mal.Visible = true;
            rad_geteilt.Visible = true;
            lbl_zahl1.Visible = true;
            lbl_zahl2.Visible = true;
            txt_zahl1.Visible = true;
            txt_zahl2.Visible = true;
            lbl_operator.Visible = true;

            // Radiobuttons werden auf false gesetzt
            rad_geteilt.Checked = false;
            rad_mal.Checked = false;
            rad_plus.Checked = false;
            rad_minus.Checked = false;

            // Textfelder werden geleert
            txt_zahl1.Text = "";
            txt_zahl2.Text = "";
            lbl_ergebnis.Text = "Ergebnis:";
            lbl_operator.Text = "";
        }

        private void txt_ergebnis_Click(object sender, EventArgs e)
        {

        }

        private void lbl_zahl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            // Gleitkommazahlen, die ein Punkt verwendet werden mit einem Komma ersetzt
            txt_zahl1.Text = txt_zahl1.Text.Replace(".", ",");
            txt_zahl2.Text = txt_zahl2.Text.Replace(".", ",");

            // errorcheck  und msgboxcheck automatisch auf false gesetzt
            errorcheck = false;
            msgboxcheck = false;

            // Überprügung, ob Fehlerhafte Werte und ungeieignete Werte (leere Textfelder) eingegeben wurden
            try
            {
                   // Wenn nichts eingegeben wird 
                if (txt_zahl1.Text != "")
                {
                    // Textfeld wird als double konventiert in einer zuvor festgelegten Variable
                    zahl1 = Convert.ToDouble(txt_zahl1.Text);
                }
                else
                {
                    // leere Textfelder sind automatische = 0
                    zahl1 = 0;
                }

                // Falls die Konventierung nicht funktioniert, weil z. B. Buchstaben eingegeben wurden
            }
            catch
            {
                // Erscheint eine Fehlermeldung als MsgBox
                if (msgboxcheck == false)
                {
                    MessageBox.Show("Bitte nur Zahlen eingeben");

                    // Damit bei der Nächsten Fehlermeldung nicht die Fehlermeldung doppelt angezeigt wird
                    // wenn bei beiden Textfeldern Buchstaben eingegeben wurden
                    msgboxcheck = true;
                }

                // Textfeld wird geleert (alternativ zu txt_zahl1.text = "")
                txt_zahl1.Clear();

                // Mit diesem Befehl wird die komplette Methode abgebrochen, dieser Befehl
                // ist mir nach dem Spagthetticode in den Sinn gekommen, möchte aber nicht den
                // Code dementsprechend anpassen
                //  return;

                // Eine Fehlermeldung ist geschehen, deswegen wird errorcheck auf true gesetzt,
                // alle weiteren Befehle werden nicht ausgeführt, da errorcheck == false erfordert wird
                // was nicht der Fall ist. Sicher gibt es eine effizientere Methode mit einem sinngemäßen
                // break des Codes, damit der folgende Code automatisch nicht ausgeführt wird.
                errorcheck = true;

              
            }

            try
            {
                if (txt_zahl2.Text != "")
                {
                    zahl2 = Convert.ToDouble(txt_zahl2.Text);
                }
                else
                {
                    zahl2 = 0;
                }
            }
            catch
            {
                if (msgboxcheck == false)
                {
                    MessageBox.Show("Bitte nur Zahlen eingeben");
                    msgboxcheck = false;
                }

                txt_zahl2.Clear();
                errorcheck = true;
            }

            // Wenn der Radiobutton + geklickt wurde
            if (rad_plus.Checked == true & errorcheck == false )
            {
                // Addition
                ergebnis = zahl1 + zahl2;

                // Ergebnis wird als String konventiert
                lbl_ergebnis.Text = "Ergebnis: Die Summe von " + zahl1 + " und " + zahl2 + " = " + ergebnis.ToString("#0.##");
            }

            else if (rad_minus.Checked == true & errorcheck == false)
            {
                ergebnis = zahl1 - zahl2;
                lbl_ergebnis.Text = "Ergebnis: Die Differenz von " + zahl1 + " und " + zahl2 + " = " + ergebnis.ToString("#0.##");
            }

            else if (rad_mal.Checked == true & errorcheck == false)
            {
                ergebnis = zahl1 * zahl2;
                lbl_ergebnis.Text = "Ergebnis: Das Produkt von " + zahl1 + " und " + zahl2 + " = " + ergebnis.ToString("#0.##");
            }

            else if (rad_geteilt.Checked == true & errorcheck == false)
            {
                ergebnis = zahl1 / zahl2;
                lbl_ergebnis.Text = "Ergebnis: Der Quotient von " + zahl1 + " und " + zahl2 + " = " + ergebnis.ToString("#0.##");
            }

            // Wenn keines der Radiobuttons geklickt wird, kommt eine Aufforderung in Form einer MsgBox
            if (rad_geteilt.Checked == false & rad_mal.Checked == false & rad_plus.Checked == false & rad_minus.Checked == false)
            {
                MessageBox.Show("Bitte wählen Sie die bevorzugte Rechenoperation aus!");
            }

            // Fast alle Anzeigen werden ausgeblendet - Fehlersuche: Das wird auch manchmal ausgeführt obwohl errorcheck == true sein sollte,
            // Problem bislang nicht gefunden - Update: alle OR Operatoren müssen in Klammern sein, Ohne Klammer gilt AND nur für rad_minus_Checked
            // Frage: wann macht man && / & und | / ||, kenne es nur doppelt
            if ((rad_geteilt.Checked == true | rad_mal.Checked == true | rad_plus.Checked == true | rad_minus.Checked == true) & errorcheck == false)
            {
                rad_plus.Visible = false;
                rad_minus.Visible = false;
                rad_mal.Visible = false;
                rad_geteilt.Visible = false;
                lbl_zahl1.Visible = false;
                lbl_zahl2.Visible = false;
                txt_zahl1.Visible = false;
                txt_zahl2.Visible = false;
                lbl_operator.Visible = false;
            }
        }
    }
}
