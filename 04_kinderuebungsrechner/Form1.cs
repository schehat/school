using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_Nr._4
{
    public partial class Form1 : Form
    {
        // Variablen deklarieren und intetialisieren
        double alter = 0, zahl1 = 0, zahl2 = 0, istErgebnis = 0, sollErgebnis = 0;
        int level = 0, anzahlAufgabe = 0, anzahlRichtig = 0, anzahlAktuell = 1, prozent = 0;
        Random zufall;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_intro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_start.Visible = false;
            grp_login.Visible = true;
        }

        private void btn_weiter_name_alter_Click(object sender, EventArgs e)
        {
            // Fehlerbehandlung
            try
            {

                if (txt_alter.Text != "")
                {

                    alter = Convert.ToDouble(txt_alter.Text);
                    lbl_alterFinal.Text = "Alter: " + alter.ToString();
                }

                else
                {
                    // Fehlermeldung
                    MessageBox.Show("Bitte geben ihr Alter ein");
                    // Code wird abgebrochen
                    return;
                }

            }
            catch
            {

                MessageBox.Show("Bitte geben Sie nur Zahlen beim Alter ein");
                txt_alter.Clear();
                return;
            }

            // Meldung
            if (alter > 16)
                {

                MessageBox.Show("Sie scheinen zu alt für diesen Übungsrechner zu sein. Der Wechsel auf ein anderen Übungsrechner ist empfehlenswert");

                }
            
            // Meldung
            if (alter > 99)
            {
                MessageBox.Show("Das maximale Alter von 99 Jahren kann nicht überschritten werden");
                return;
            }

            // Fehlerbehandlung
            if (txt_name.Text == "")
            {

                MessageBox.Show("Bitte geben Sie einen Benutzernamen ein");
                return;
            }
            else
            {
                lbl_nameFinal.Text = "Benutzername: " + txt_name.Text;
            }

            // Layer wechseln
            grp_login.Visible = false;
            grp_operator_level_number.Visible = true;
        }

        private void txt_alter_TextChanged(object sender, EventArgs e)
        {
                

            }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_number_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_anzahl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_startMenue_Click(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_start.Visible = true;
            grp_rechnen.Visible = false;

            // reset der Variablen - Neustart des Programmes
            Application.Restart();
        }

        private void btb_weiterRechnen_Click(object sender, EventArgs e)
        {
            // Labels ausblenden 
            lbl_richtigErgebnis.Visible = false;
            lbl_richtig.Visible = false;
            lbl_falsch.Visible = false;

            // Textbox leeren
            txt_ergebnis.Clear();

            // Ausgabe der Anzahl der Aufgabe
            lbl_anzahlFinal.Text = "Aufgabe " + anzahlAktuell.ToString() + " von " + anzahlAufgabe.ToString();

            // Initialisieren von Zufallszahlen
            Random zufall = new Random();

            // Zufallszahlen generieren nach level
            if (cbo_level.SelectedIndex == 0)
            {
                zahl1 = zufall.Next(1, 11);
                zahl2 = zufall.Next(1, 11);
            }
            else if (cbo_level.SelectedIndex == 1)
            {
                zahl1 = zufall.Next(11, 21);
                zahl2 = zufall.Next(11, 21);
            }
            else
            {
                zahl1 = zufall.Next(21, 31);
                zahl2 = zufall.Next(21, 31);
            }

            // Ausgabe der Zufallszahlen
            lbl_zahl1.Text = zahl1.ToString();
            lbl_zahl2.Text = zahl2.ToString();

            // Um Fehler zu vermeiden wenn Weiter-Button mehrmals hintereinander geklickt wird
            btn_weiterRechnen.Visible = false;

            // Muss wieder angezeigt werden
            btn_ueberpruefen.Visible = true;

        }

        private void btn_ueberpruefen_Click(object sender,   EventArgs e)
        {

            // Gleitkommazahlen, die ein Punkt verwendet werden mit einem Komma ersetzt
            txt_ergebnis.Text = txt_ergebnis.Text.Replace(".", ",");

            // Inhalt der Labels in Double umwandeln
            zahl1 = Convert.ToDouble(lbl_zahl1.Text);
            zahl2 = Convert.ToDouble(lbl_zahl2.Text);

            // Berechnung des Ergebnisses nach Operator
            if (rad_plus.Checked)
                {
                istErgebnis = zahl1 + zahl2;
                }

            if (rad_minus.Checked)
                {
                istErgebnis = zahl1 - zahl2;
                }

            if (rad_mal.Checked)
                {
                istErgebnis = zahl1 * zahl2;
                }

            if (rad_geteilt.Checked)
                {
                istErgebnis = zahl1 / zahl2;
                }

            // Fehlerbehandlung + vom User eingegeben Inhalt in Double umwandeln
            try
            {
                if (txt_ergebnis.Text != "")
                {
                    sollErgebnis = Convert.ToDouble(txt_ergebnis.Text);
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie ein Ergebnis an");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie Zahlen beim Ergebnis an");
                return;
            }

            // Fehler beim zählen deswegen behebe ich das so

            //besondere Abfrage zum Vergleich der beiden Ergebnisse aufgrund der Dezimalzahlen
            if (rad_geteilt.Checked)
            {
                if(Math.Round(istErgebnis) == sollErgebnis | Math.Round(istErgebnis,1) == sollErgebnis | Math.Round(istErgebnis, 2) == sollErgebnis | Math.Round(istErgebnis, 3) == sollErgebnis )
                {
                    // Anzeige richtig einblenden
                    lbl_richtig.Visible = true;
                    lbl_falsch.Visible = false;

                    // Zähler hochzählen
                    anzahlAktuell += 1;
                    anzahlRichtig += 1;

                }
                else
                {
                    // Anzeige falsch einblenden
                    lbl_falsch.Visible = true;
                    lbl_richtig.Visible = false;

                    // Zähler hochzählen 
                    anzahlAktuell += 1;
                }
            }
            else // Abfrage bei den anderen Operatoren
            {
                if(istErgebnis == sollErgebnis)
                {
                    lbl_richtig.Visible = true;
                    lbl_falsch.Visible = false;
                    anzahlAktuell += 1;
                    anzahlRichtig += 1;

                }
                else
                {
                    lbl_falsch.Visible = true;
                    lbl_richtig.Visible = false;
                    anzahlAktuell += 1;
                }
            }

            // richtiges Ergebnis anzeigen
            lbl_richtigErgebnis.Text = "Das Ergebnis: " + istErgebnis.ToString("#0.##");

            // Anteil richtiger Ergebnisse in Prozent - anzahlAktuel - 1, weil der bei 1 angefangen hat anzahlRichtig bei 0
            prozent = anzahlRichtig * 100 / (anzahlAktuell - 1);

            // Anzeige des Ergebnisses und Prozent
            lbl_richtigErgebnis.Visible = true;
            lbl_prozent.Visible = true;

            // Inhalt des Prozentlabels
            lbl_prozent.Text = "Prozentsatz richtig: " + prozent + " %";

            // Um Fehler zu vermeiden wenn Überprüfen-Button mehrmals hintereinander geklickt wird
            btn_ueberpruefen.Visible = false;

            // Muss wieder angezeigt werden
            btn_weiterRechnen.Visible = true;

            // Beendung der Übung wenn Anzahl der Übungsaufgaben erreicht wurde
            if (anzahlAktuell > anzahlAufgabe)
            {
                lbl_infoFertig.Visible = true;
                btn_ueberpruefen.Visible = false;
                btn_weiterRechnen.Visible = false;
                btn_zurueck.Visible = false;
            }
            
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            grp_operator_level_number.Visible = true;
            grp_rechnen.Visible = false;
            txt_anzahl.Visible = false;
            lbl_anzahl.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void grp_operator_level_number_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            grp_start.Visible = false;
            grp_login.Visible = true;
        }

        private void cbo_level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_level_operator_number_Click(object sender, EventArgs e)
        {
            // Fehlerbehandlung
            if (rad_plus.Checked == true || rad_minus.Checked == true || rad_mal.Checked == true || rad_geteilt.Checked == true)
            {
                // Operator als Variable speichern komplizierter als gedacht 

                // Label anpassen
                if (rad_plus.Checked == true)
                {
                    lbl_operatorFinal.Text = "Rechenart: " + "+";
                    lbl_operatorAnzeige.Text = "+";
                }
                if (rad_minus.Checked == true)
                {
                    lbl_operatorFinal.Text = "Rechenart: " + "-";
                    lbl_operatorAnzeige.Text = "-";
                }
                if (rad_mal.Checked == true)
                {
                    lbl_operatorFinal.Text = "Rechenart: " + "*";
                    lbl_operatorAnzeige.Text = "*";
                }
                if (rad_geteilt.Checked == true)
                {
                    lbl_operatorFinal.Text = "Rechenart: " + "/";
                    lbl_operatorAnzeige.Text = "/";
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Rechenart");
                return;
            }

            // Zuweisung des levels und Label Anpassung + Fehlersuche
            if(cbo_level.SelectedIndex == 0 | cbo_level.SelectedIndex == 1 | cbo_level.SelectedIndex == 2 )
            {
                level = cbo_level.SelectedIndex;
                lbl_levelFinal.Text = "Schwierigkeitsgrad: " + cbo_level.Text;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie den Schwierigkeitsgrad");
                return;
            }

            // Fehlerbehandlung
            try
            {

                if (txt_anzahl.Text != "" )
                {

                    anzahlAufgabe = Convert.ToInt32(txt_anzahl.Text);
                    
                    if(anzahlAufgabe < 11)
                    {
                        // Anzeige der Anzahl der Aufgaben
                        lbl_anzahlFinal.Text = "Aufgabe " + anzahlAktuell.ToString() + " von " + anzahlAufgabe.ToString();

                    }
                    else
                    {
                        // Fehlermeldung
                        MessageBox.Show("Die maximale Anzahl an Aufgaben von 10 darf nicht überschritten werden");

                        // Code wird abgebrochen
                        return;
                    }
                    
                }

                else
                {
                    // Fehlermeldung
                    MessageBox.Show("Bitte geben Sie ganze Zahlen bei der Anzahl der Aufgaben an");

                    // Code wird abgebrochen
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlen an");
                txt_anzahl.Clear();
                return;
            }

            // Zahlen generieren und zuweisen
            Random zufall = new Random();

            if (cbo_level.SelectedIndex == 0)
            {
                zahl1 = zufall.Next(1, 11);
                zahl2 = zufall.Next(1, 11);
            }
            else if (cbo_level.SelectedIndex == 1)
            {
                zahl1 = zufall.Next(11, 21);
                zahl2 = zufall.Next(11, 21);
            }
            
            else
            {
                zahl1 = zufall.Next(21, 31);
                zahl2 = zufall.Next(21, 31);
            }

            lbl_zahl1.Text = zahl1.ToString();
            lbl_zahl2.Text = zahl2.ToString();


            grp_operator_level_number.Visible = false;
            grp_rechnen.Visible = true;
        }

        private void grp_rechnen_Enter(object sender, EventArgs e)
        {

        }
    }
    }

