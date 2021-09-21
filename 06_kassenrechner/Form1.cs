using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_Nr._6
{
    public partial class Form1 : Form
    {
        // Variablen deklarieren und initilalisieren
        double  zahln1 = 0, zahln2 = 0, zahln3 = 0, zahln4 = 0, zahln5 = 0,
                zahlb1 = 0, zahlb2 = 0, zahlb3 = 0, zahlb4 = 0, zahlb5 = 0,
                zahle1 = 0, zahle2 = 0, zahle3 = 0, zahle4 = 0, zahle5 = 0,
                zahlrabatt, zahltotal;
        string date, time;
        Random ran;

        private void lbl_end_line1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_end_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_end_start_Click(object sender, EventArgs e)
        {
            // Neustart des Programmes
            Application.Restart();
        }

        private void btn_end_zurueck_Click(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_end.Visible = false;
            grp_navi.Visible = true;
            lbl_navi_end.Visible = false;
            pic_navi_end.Visible = false;
        }

        private void pic_navi_end_Click(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_navi.Visible = false;
            grp_end.Visible = true;

            // Datum ermitteln
            date = System.DateTime.Now.ToShortDateString();
            lbl_end_date.Text = "Datum:" + date;

            // Uhrzeit ermitteln
            time = DateTime.Now.ToShortTimeString();
            lbl_end_time.Text = "Zeit: " + time;

            // zufällige Zahl für Kasse generieren
            ran = new Random();
            lbl_end_kasse.Text = "Kasse: " + Convert.ToString(ran.Next(1, 4));

            // Überprüfen ob zahln1 ungleich 0 ist, wenn ja dann wurde damit gerechnet und ich kann damit weiterarbeiten
            if (zahln1 != 0)
            {
                // Die Labels anzeigen lassen
                lbl_end_1.Visible = true;
                lbl_end_art1.Visible = true;
                lbl_end_klasse1.Visible = true;
                lbl_end_netto1.Visible = true;
                lbl_end_brutto1.Visible = true;
                lbl_end_betrag1.Visible = true;

                // Labels mit Text füllen - vom davorigen Layer die Werte übernehmen

                lbl_end_art1.Text = cbo_navi_art1.Text;

                if (cbo_navi_klasse1.SelectedIndex == 0)
                {
                    lbl_end_klasse1.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse1.Text = "19,00";
                }

                lbl_end_netto1.Text = zahln1.ToString("#0.00") + " €";
                lbl_end_brutto1.Text = zahlb1.ToString("#0.00") + " €";
                lbl_end_betrag1.Text = zahle1.ToString("#0.00") + " €";
            }

            // Wenn nicht, dann soll das gar nicht angezeigt werden
            else
            {
                lbl_end_1.Visible = false;
                lbl_end_art1.Visible = false;
                lbl_end_klasse1.Visible = false; ;
                lbl_end_netto1.Visible = false; ;
                lbl_end_brutto1.Visible = false; ;
                lbl_end_betrag1.Visible = false; ;
            }

            if (zahln2 != 0)
            {
                lbl_end_2.Visible = true;
                lbl_end_art2.Visible = true;
                lbl_end_klasse2.Visible = true;
                lbl_end_netto2.Visible = true;
                lbl_end_brutto2.Visible = true;
                lbl_end_betrag2.Visible = true;

                lbl_end_art2.Text = cbo_navi_art2.Text;

                if (cbo_navi_klasse2.SelectedIndex == 0)
                {
                    lbl_end_klasse2.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse2.Text = "19,00";
                }

                lbl_end_netto2.Text = zahln2.ToString("#0.00") + " €";
                lbl_end_brutto2.Text = zahlb2.ToString("#0.00") + " €";
                lbl_end_betrag2.Text = zahle2.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_2.Visible = false;
                lbl_end_art2.Visible = false;
                lbl_end_klasse2.Visible = false; ;
                lbl_end_netto2.Visible = false; ;
                lbl_end_brutto2.Visible = false; ;
                lbl_end_betrag2.Visible = false; ;
            }

            if (zahln3 != 0)
            {
                lbl_end_3.Visible = true;
                lbl_end_art3.Visible = true;
                lbl_end_klasse3.Visible = true;
                lbl_end_netto3.Visible = true;
                lbl_end_brutto3.Visible = true;
                lbl_end_betrag3.Visible = true;

                lbl_end_art3.Text = cbo_navi_art3.Text;

                if (cbo_navi_klasse3.SelectedIndex == 0)
                {
                    lbl_end_klasse3.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse3.Text = "19,00";
                }

                lbl_end_netto3.Text = zahln3.ToString("#0.00") + " €";
                lbl_end_brutto3.Text = zahlb3.ToString("#0.00") + " €";
                lbl_end_betrag3.Text = zahle3.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_3.Visible = false;
                lbl_end_art3.Visible = false;
                lbl_end_klasse3.Visible = false; ;
                lbl_end_netto3.Visible = false; ;
                lbl_end_brutto3.Visible = false; ;
                lbl_end_betrag3.Visible = false; ;
            }

            if (zahln4 != 0)
            {
                lbl_end_4.Visible = true;
                lbl_end_art4.Visible = true;
                lbl_end_klasse4.Visible = true;
                lbl_end_netto4.Visible = true;
                lbl_end_brutto4.Visible = true;
                lbl_end_betrag4.Visible = true;

                lbl_end_art4.Text = cbo_navi_art4.Text;

                if (cbo_navi_klasse4.SelectedIndex == 0)
                {
                    lbl_end_klasse4.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse4.Text = "19,00";
                }

                lbl_end_netto4.Text = zahln4.ToString("#0.00") + " €";
                lbl_end_brutto4.Text = zahlb4.ToString("#0.00") + " €";
                lbl_end_betrag4.Text = zahle4.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_4.Visible = false;
                lbl_end_art4.Visible = false;
                lbl_end_klasse4.Visible = false; ;
                lbl_end_netto4.Visible = false; ;
                lbl_end_brutto4.Visible = false; ;
                lbl_end_betrag4.Visible = false; ;
            }

            if (zahln5 != 0)
            {
                lbl_end_5.Visible = true;
                lbl_end_art5.Visible = true;
                lbl_end_klasse5.Visible = true;
                lbl_end_netto5.Visible = true;
                lbl_end_brutto5.Visible = true;
                lbl_end_betrag5.Visible = true;

                lbl_end_art5.Text = cbo_navi_art5.Text;

                if (cbo_navi_klasse5.SelectedIndex == 0)
                {
                    lbl_end_klasse5.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse5.Text = "19,00";
                }

                lbl_end_netto5.Text = zahln5.ToString("#0.00") + " €";
                lbl_end_brutto5.Text = zahlb5.ToString("#0.00") + " €";
                lbl_end_betrag5.Text = zahle5.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_5.Visible = false;
                lbl_end_art5.Visible = false;
                lbl_end_klasse5.Visible = false; ;
                lbl_end_netto5.Visible = false; ;
                lbl_end_brutto5.Visible = false; ;
                lbl_end_betrag5.Visible = false; ;
            }

            zahltotal = zahle1 + zahle2 + zahle3 + zahle4 + zahle5;
            lbl_end_total.Text = "Total: " + zahltotal.ToString("#0.00") + " €";

        }

        private void lbl_navi_end_Click(object sender, EventArgs e)
        {
            // das gleiche wie bei der davorigen click-event
            grp_navi.Visible = false;
            grp_end.Visible = true;

            date = System.DateTime.Now.ToShortDateString();
            lbl_end_date.Text = "Datum:" + date;

            time = DateTime.Now.ToShortTimeString();
            lbl_end_time.Text = "Zeit: " + time;

            ran = new Random();
            lbl_end_kasse.Text = "Kasse: " + Convert.ToString(ran.Next(1, 4));

            if (zahln1 != 0)
            {
                lbl_end_1.Visible = true;
                lbl_end_art1.Visible = true;
                lbl_end_klasse1.Visible = true;
                lbl_end_netto1.Visible = true;
                lbl_end_brutto1.Visible = true;
                lbl_end_betrag1.Visible = true;

                lbl_end_art1.Text = cbo_navi_art1.Text;
                
                if(cbo_navi_klasse1.SelectedIndex == 0)
                {
                    lbl_end_klasse1.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse1.Text = "19,00";
                }

                lbl_end_netto1.Text = zahln1.ToString("#0.00") + " €";
                lbl_end_brutto1.Text = zahlb1.ToString("#0.00") + " €";
                lbl_end_betrag1.Text = zahle1.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_1.Visible = false;
                lbl_end_art1.Visible = false;
                lbl_end_klasse1.Visible = false; ;
                lbl_end_netto1.Visible = false; ;
                lbl_end_brutto1.Visible = false; ;
                lbl_end_betrag1.Visible = false; ;
            }

            if (zahln2 != 0)
            {
                lbl_end_2.Visible = true;
                lbl_end_art2.Visible = true;
                lbl_end_klasse2.Visible = true;
                lbl_end_netto2.Visible = true;
                lbl_end_brutto2.Visible = true;
                lbl_end_betrag2.Visible = true;

                lbl_end_art2.Text = cbo_navi_art2.Text;

                if (cbo_navi_klasse2.SelectedIndex == 0)
                {
                    lbl_end_klasse2.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse2.Text = "19,00";
                }

                lbl_end_netto2.Text = zahln2.ToString("#0.00") + " €";
                lbl_end_brutto2.Text = zahlb2.ToString("#0.00") + " €";
                lbl_end_betrag2.Text = zahle2.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_2.Visible = false;
                lbl_end_art2.Visible = false;
                lbl_end_klasse2.Visible = false; ;
                lbl_end_netto2.Visible = false; ;
                lbl_end_brutto2.Visible = false; ;
                lbl_end_betrag2.Visible = false; ;
            }

            if (zahln3 != 0)
            {
                lbl_end_3.Visible = true;
                lbl_end_art3.Visible = true;
                lbl_end_klasse3.Visible = true;
                lbl_end_netto3.Visible = true;
                lbl_end_brutto3.Visible = true;
                lbl_end_betrag3.Visible = true;

                lbl_end_art3.Text = cbo_navi_art3.Text;

                if (cbo_navi_klasse3.SelectedIndex == 0)
                {
                    lbl_end_klasse3.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse3.Text = "19,00";
                }

                lbl_end_netto3.Text = zahln3.ToString("#0.00") + " €";
                lbl_end_brutto3.Text = zahlb3.ToString("#0.00") + " €";
                lbl_end_betrag3.Text = zahle3.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_3.Visible = false;
                lbl_end_art3.Visible = false;
                lbl_end_klasse3.Visible = false; ;
                lbl_end_netto3.Visible = false; ;
                lbl_end_brutto3.Visible = false; ;
                lbl_end_betrag3.Visible = false; ;
            }

            if (zahln4 != 0)
            {
                lbl_end_4.Visible = true;
                lbl_end_art4.Visible = true;
                lbl_end_klasse4.Visible = true;
                lbl_end_netto4.Visible = true;
                lbl_end_brutto4.Visible = true;
                lbl_end_betrag4.Visible = true;

                lbl_end_art4.Text = cbo_navi_art4.Text;

                if (cbo_navi_klasse4.SelectedIndex == 0)
                {
                    lbl_end_klasse4.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse4.Text = "19,00";
                }

                lbl_end_netto4.Text = zahln4.ToString("#0.00") + " €";
                lbl_end_brutto4.Text = zahlb4.ToString("#0.00") + " €";
                lbl_end_betrag4.Text = zahle4.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_4.Visible = false;
                lbl_end_art4.Visible = false;
                lbl_end_klasse4.Visible = false; ;
                lbl_end_netto4.Visible = false; ;
                lbl_end_brutto4.Visible = false; ;
                lbl_end_betrag4.Visible = false; ;
            }

            if (zahln5 != 0)
            {
                lbl_end_5.Visible = true;
                lbl_end_art5.Visible = true;
                lbl_end_klasse5.Visible = true;
                lbl_end_netto5.Visible = true;
                lbl_end_brutto5.Visible = true;
                lbl_end_betrag5.Visible = true;

                lbl_end_art5.Text = cbo_navi_art5.Text;

                if (cbo_navi_klasse5.SelectedIndex == 0)
                {
                    lbl_end_klasse5.Text = "7,00";
                }
                else
                {
                    lbl_end_klasse5.Text = "19,00";
                }

                lbl_end_netto5.Text = zahln5.ToString("#0.00") + " €";
                lbl_end_brutto5.Text = zahlb5.ToString("#0.00") + " €";
                lbl_end_betrag5.Text = zahle5.ToString("#0.00") + " €";
            }

            else
            {
                lbl_end_5.Visible = false;
                lbl_end_art5.Visible = false;
                lbl_end_klasse5.Visible = false; ;
                lbl_end_netto5.Visible = false; ;
                lbl_end_brutto5.Visible = false; ;
                lbl_end_betrag5.Visible = false; ;
            }

            zahltotal = zahle1 + zahle2 + zahle3 + zahle4 + zahle5;
            lbl_end_total.Text = "Total: " + zahltotal.ToString("#0.00") + " €";
        }

        private void cbo_navi_rabatt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wenn ja, dann soll eine Textbox aufploppen
            if(cbo_navi_rabatt.SelectedIndex == 5)
            {
                txt_navi_rabatt.Visible = true;
            }
        }

        private void btn_navi_berechnen_switch_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob die Combobox benutz wurde, sonst kommt es zu einer Fehlermeldung
            if (lbl_navi_1.Visible == true)
            {
                switch (cbo_navi_art1.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art1.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                switch (cbo_navi_art2.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art2.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                switch (cbo_navi_art3.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art3.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                switch (cbo_navi_art4.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art4.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                switch (cbo_navi_art5.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art5.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_1.Visible == true)
            {
                switch (cbo_navi_klasse1.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse1.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                switch (cbo_navi_klasse2.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse2.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                switch (cbo_navi_klasse3.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse3.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                switch (cbo_navi_klasse4.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse4.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                switch (cbo_navi_klasse5.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse5.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            // Replace Befehl, damit die Punkte in Kommata ersetzt werden können für die weiteren Berechnungen
            txt_navi_netto1.Text = txt_navi_netto1.Text.Replace(".", ",");
            txt_navi_netto2.Text = txt_navi_netto2.Text.Replace(".", ",");
            txt_navi_netto3.Text = txt_navi_netto3.Text.Replace(".", ",");
            txt_navi_netto4.Text = txt_navi_netto4.Text.Replace(".", ",");
            txt_navi_netto5.Text = txt_navi_netto5.Text.Replace(".", ",");

            txt_navi_brutto1.Text = txt_navi_brutto1.Text.Replace(".", ",");
            txt_navi_brutto2.Text = txt_navi_brutto2.Text.Replace(".", ",");
            txt_navi_brutto3.Text = txt_navi_brutto3.Text.Replace(".", ",");
            txt_navi_brutto4.Text = txt_navi_brutto4.Text.Replace(".", ",");
            txt_navi_brutto5.Text = txt_navi_brutto5.Text.Replace(".", ",");

            // Jeweils die Anzeige checken, ob was gemacht werden soll 
            // dann versuchen den String in eine Zahl umzuwandeln 
            // sonst kommt es zu einer Fehlermeldung und Code wird nicht weiter ausgeführt
            if (lbl_navi_1.Visible == true)
            {
                if (txt_navi_netto1.Text != "" && txt_navi_brutto1.Text == "")
                {
                    try
                    {
                        zahln1 = Convert.ToDouble(txt_navi_netto1.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto1.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto1.Text != "" && txt_navi_netto1.Text == "")
                {
                    try
                    {
                        zahlb1 = Convert.ToDouble(txt_navi_brutto1.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto1.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto1.Text == "" && txt_navi_netto1.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto1.Text != "" && txt_navi_netto1.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto1.Clear();
                    txt_navi_brutto1.Clear();
                    return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                if (txt_navi_netto2.Text != "" && txt_navi_brutto2.Text == "")
                {
                    try
                    {
                        zahln2 = Convert.ToDouble(txt_navi_netto2.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto2.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto2.Text != "" && txt_navi_netto2.Text == "")
                {
                    try
                    {
                        zahlb2 = Convert.ToDouble(txt_navi_brutto2.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto2.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto2.Text == "" && txt_navi_netto2.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto2.Text != "" && txt_navi_netto2.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto2.Clear();
                    txt_navi_brutto2.Clear();
                    return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                if (txt_navi_netto3.Text != "" && txt_navi_brutto3.Text == "")
                {
                    try
                    {
                        zahln3 = Convert.ToDouble(txt_navi_netto3.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto3.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto3.Text != "" && txt_navi_netto3.Text == "")
                {
                    try
                    {
                        zahlb3 = Convert.ToDouble(txt_navi_brutto3.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto3.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto3.Text == "" && txt_navi_netto3.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto3.Text != "" && txt_navi_netto3.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto3.Clear();
                    txt_navi_brutto3.Clear();
                    return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                if (txt_navi_netto4.Text != "" && txt_navi_brutto4.Text == "")
                {
                    try
                    {
                        zahln4 = Convert.ToDouble(txt_navi_netto4.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto4.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto4.Text != "" && txt_navi_netto4.Text == "")
                {
                    try
                    {
                        zahlb4 = Convert.ToDouble(txt_navi_brutto4.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto4.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto4.Text == "" && txt_navi_netto4.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto4.Text != "" && txt_navi_netto4.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto4.Clear();
                    txt_navi_brutto4.Clear();
                    return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                if (txt_navi_netto5.Text != "" && txt_navi_brutto5.Text == "")
                {
                    try
                    {
                        zahln5 = Convert.ToDouble(txt_navi_netto5.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto5.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto5.Text != "" && txt_navi_netto5.Text == "")
                {
                    try
                    {
                        zahlb5 = Convert.ToDouble(txt_navi_brutto5.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto5.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto5.Text == "" && txt_navi_netto5.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto5.Text != "" && txt_navi_netto5.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto5.Clear();
                    txt_navi_brutto5.Clear();
                    return;
                }
            }

            switch (cbo_navi_rabatt.Text)
            {
                case "0%":

                    // Wenn die Zahl 1 ungleich 0 ist, heißt das ich kann damit rechnen und dann wird
                    // jeweils die fehlenden Werte berechnet
                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahle1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahle1 = zahln1 * 1.19;
                        }
                        zahlb1 = zahle1;
                        Math.Round(zahle1, 2);
                        txt_navi_brutto1.Text = zahle1.ToString("#0.00");
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1;
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahle2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahle2 = zahln2 * 1.19;
                        }
                        zahlb2 = zahle2;
                        Math.Round(zahle2, 2);
                        txt_navi_brutto2.Text = zahle2.ToString("#0.00");
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2;
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahle3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahle3 = zahln3 * 1.19;
                        }
                        zahlb3 = zahle3;
                        Math.Round(zahle3, 2);
                        txt_navi_brutto3.Text = zahle3.ToString("#0.00");
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3;
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahle4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahle4 = zahln4 * 1.19;
                        }
                        zahlb4 = zahle4;
                        Math.Round(zahle4, 2);
                        txt_navi_brutto4.Text = zahle4.ToString("#0.00");
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4;
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahle5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahle5 = zahln5 * 1.19;
                        }
                        zahlb5 = zahle5;
                        Math.Round(zahle5, 2);
                        txt_navi_brutto5.Text = zahle5.ToString("#0.00");
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5;
                        Math.Round(zahle5, 2);
                    }

                    break;

                case "5%":

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.95;
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.95;
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.95;
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.95;
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.95;
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.95;
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.95;
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.95;
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.95;
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.95;
                        Math.Round(zahle5, 2);
                    }

                    break;

                case "10%":

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.9;
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.9;
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.9;
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.9;
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.9;
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.9;
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.9;
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.9;
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.9;
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.9;
                        Math.Round(zahle5, 2);
                    }

                    break;

                case "15%":

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.85;
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.85;
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.85;
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.85;
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.85;
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.85;
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.85;
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.85;
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.85;
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.85;
                        Math.Round(zahle5, 2);
                    }

                    break;

                case "20%":

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.8;
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * 0.8;
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.8;
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * 0.8;
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.8;
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * 0.8;
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.8;
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * 0.8;
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.8;
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * 0.8;
                        Math.Round(zahle5, 2);
                    }

                    break;


                case "Sonstige":

                    try
                    {
                        zahlrabatt = Convert.ToDouble(txt_navi_rabatt.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie einen beliebige Rabatt ein");
                        txt_navi_rabatt.Clear();
                        return;
                    }

                    if (zahlrabatt < 0 || zahlrabatt > 100)
                    {
                        MessageBox.Show("Bitte geben Sie einen Zahlwert größer 0 und kleiner 100 ein");
                        txt_navi_rabatt.Clear();
                        return;
                    }

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle5, 2);
                    }

                    break;

                default:
                    MessageBox.Show("Bitte wählen Sie die angezeigten Rabattaktionen aus");
                    cbo_navi_rabatt.Text = "Rabattaktion";
                    return;
            }

            // Picture/Label und Button ein- und ausblenden
            pic_navi_end.Visible = true;
            lbl_navi_end.Visible = true;

            btn_navi_berechnen_if.Visible = false;
            btn_navi_berechnen_switch.Visible = false;
    }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Ein- und Ausblenden von Objekten
            grp_start.Visible = false;
            grp_navi.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_navi_weniger_Click(object sender, EventArgs e)
        {
            // Schritt für Schritt die Labels, Textfelder und Comboboxen ein- oder ausblenden je nachdem 
            // dafür muss man pberprüfen, ob der nächste nicht da ist, sonst kommt zu einer Kette von von ausblenden
            // deswegen muss am Ende noch ein return Befehl hinzugefügt werdeb
            if (lbl_navi_2.Visible == true && lbl_navi_3.Visible == false)
            {
                lbl_navi_2.Visible = false;
                cbo_navi_art2.Visible = false;
                cbo_navi_klasse2.Visible = false;
                lbl_navi_netto2.Visible = false;
                txt_navi_netto2.Visible = false;
                lbl_navi_brutto2.Visible = false;
                txt_navi_brutto2.Visible = false;
                return;
            }

            if (lbl_navi_3.Visible == true && lbl_navi_4.Visible == false)
            {
                lbl_navi_3.Visible = false;
                cbo_navi_art3.Visible = false;
                cbo_navi_klasse3.Visible = false;
                lbl_navi_netto3.Visible = false;
                txt_navi_netto3.Visible = false;
                lbl_navi_brutto3.Visible = false;
                txt_navi_brutto3.Visible = false;
                return;
            }

            if (lbl_navi_4.Visible == true && lbl_navi_5.Visible == false)
            {
                lbl_navi_4.Visible = false;
                cbo_navi_art4.Visible = false;
                cbo_navi_klasse4.Visible = false;
                lbl_navi_netto4.Visible = false;
                txt_navi_netto4.Visible = false;
                lbl_navi_brutto4.Visible = false;
                txt_navi_brutto4.Visible = false;
                return;
            }

            if (lbl_navi_5.Visible == true)
            {
                lbl_navi_5.Visible = false;
                cbo_navi_art5.Visible = false;
                cbo_navi_klasse5.Visible = false;
                lbl_navi_netto5.Visible = false;
                txt_navi_netto5.Visible = false;
                lbl_navi_brutto5.Visible = false;
                txt_navi_brutto5.Visible = false;
                return;
            }
        }

        private void btn_navi_mehr_Click(object sender, EventArgs e)
        {
            if (lbl_navi_1.Visible == true && lbl_navi_2.Visible == false)
            {
                lbl_navi_2.Visible = true;
                cbo_navi_art2.Visible = true;
                cbo_navi_klasse2.Visible = true;
                lbl_navi_netto2.Visible = true;
                txt_navi_netto2.Visible = true;
                lbl_navi_brutto2.Visible = true;
                txt_navi_brutto2.Visible = true;
                return;
            }

            if(lbl_navi_2.Visible == true && lbl_navi_3.Visible == false)
            {
                lbl_navi_3.Visible = true;
                cbo_navi_art3.Visible = true;
                cbo_navi_klasse3.Visible = true;
                lbl_navi_netto3.Visible = true;
                txt_navi_netto3.Visible = true;
                lbl_navi_brutto3.Visible = true;
                txt_navi_brutto3.Visible = true;
                return;
            }

            if (lbl_navi_3.Visible == true && lbl_navi_4.Visible == false)
            {
                lbl_navi_4.Visible = true;
                cbo_navi_art4.Visible = true;
                cbo_navi_klasse4.Visible = true;
                lbl_navi_netto4.Visible = true;
                txt_navi_netto4.Visible = true;
                lbl_navi_brutto4.Visible = true;
                txt_navi_brutto4.Visible = true;
                return;
            }

            if (lbl_navi_4.Visible == true && lbl_navi_5.Visible == false)
            {
                lbl_navi_5.Visible = true;
                cbo_navi_art5.Visible = true;
                cbo_navi_klasse5.Visible = true;
                lbl_navi_netto5.Visible = true;
                txt_navi_netto5.Visible = true;
                lbl_navi_brutto5.Visible = true;
                txt_navi_brutto5.Visible = true;
                return;
            }
        }

        private void btn_navi_zurueck_Click(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_navi.Visible = false;
            grp_start.Visible = true;
        }

        private void btn_navi_reset_Click(object sender, EventArgs e)
        {
            // alles leeren bzw. auf den vorherigen Zustand zurücksetzen
            cbo_navi_art1.Text = "Artikelart";
            cbo_navi_art2.Text = "Artikelart";
            cbo_navi_art3.Text = "Artikelart";
            cbo_navi_art4.Text = "Artikelart";
            cbo_navi_art5.Text = "Artikelart";

            cbo_navi_klasse1.Text = "Mehrwertsteuerklasse";
            cbo_navi_klasse2.Text = "Mehrwertsteuerklasse";
            cbo_navi_klasse3.Text = "Mehrwertsteuerklasse";
            cbo_navi_klasse4.Text = "Mehrwertsteuerklasse";
            cbo_navi_klasse5.Text = "Mehrwertsteuerklasse";

            txt_navi_netto1.Clear();
            txt_navi_netto2.Clear();
            txt_navi_netto3.Clear();
            txt_navi_netto4.Clear();
            txt_navi_netto5.Clear();

            txt_navi_brutto1.Clear();
            txt_navi_brutto2.Clear();
            txt_navi_brutto3.Clear();
            txt_navi_brutto4.Clear();
            txt_navi_brutto5.Clear();

            zahln1 = 0;
            zahln2 = 0;
            zahln3 = 0;
            zahln4 = 0;
            zahln5 = 0;
            zahlb1 = 0;
            zahlb2 = 0;
            zahlb3 = 0;
            zahlb4 = 0;
            zahlb5 = 0;
            zahle1 = 0;
            zahle2 = 0;
            zahle3 = 0;
            zahle4 = 0;
            zahle5 = 0;

            // Button und Labels/Pictures ein- und ausblenden
            btn_navi_berechnen_if.Visible = true;
            btn_navi_berechnen_switch.Visible = true;
            lbl_navi_end.Visible = false;
            pic_navi_end.Visible = false;
        }

        private void cbo_navi_art1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_navi_berechnen_if_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob die Combobox benutz wurde, sonst kommt es zu einer Fehlermeldung
            if (lbl_navi_1.Visible == true)
            {
                switch (cbo_navi_art1.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art1.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                switch (cbo_navi_art2.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art2.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                switch (cbo_navi_art3.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art3.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                switch (cbo_navi_art4.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art4.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                switch (cbo_navi_art5.Text)
                {
                    case "Getränke": break;
                    case "Gewürze": break;
                    case "Süßwaren": break;
                    case "Milchprodukte": break;
                    case "Getreideprodukte": break;
                    case "Fleischprodukte": break;
                    case "Naturprodukte": break;
                    case "Meeresfrüchte": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Artikelarten aus");
                        cbo_navi_art5.Text = "Artikelart";
                        return;
                }
            }

            if (lbl_navi_1.Visible == true)
            {
                switch (cbo_navi_klasse1.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse1.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                switch (cbo_navi_klasse2.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse2.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                switch (cbo_navi_klasse3.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse3.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                switch (cbo_navi_klasse4.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse4.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                switch (cbo_navi_klasse5.Text)
                {
                    case "7%": break;
                    case "19%": break;
                    default:
                        MessageBox.Show("Bitte wählen Sie die angezeigten Mehrwertsteuerklassen aus");
                        cbo_navi_klasse5.Text = "Mehrwertsteuerklasse";
                        return;
                }
            }

            // Replace Befehl, damit die Punkte in Kommata ersetzt werden können für die weiteren Berechnungen
            txt_navi_netto1.Text = txt_navi_netto1.Text.Replace(".", ",");
            txt_navi_netto2.Text = txt_navi_netto2.Text.Replace(".", ",");
            txt_navi_netto3.Text = txt_navi_netto3.Text.Replace(".", ",");
            txt_navi_netto4.Text = txt_navi_netto4.Text.Replace(".", ",");
            txt_navi_netto5.Text = txt_navi_netto5.Text.Replace(".", ",");

            txt_navi_brutto1.Text = txt_navi_brutto1.Text.Replace(".", ",");
            txt_navi_brutto2.Text = txt_navi_brutto2.Text.Replace(".", ",");
            txt_navi_brutto3.Text = txt_navi_brutto3.Text.Replace(".", ",");
            txt_navi_brutto4.Text = txt_navi_brutto4.Text.Replace(".", ",");
            txt_navi_brutto5.Text = txt_navi_brutto5.Text.Replace(".", ",");

            // Jeweils die Anzeige checken, ob was gemacht werden soll 
            // dann versuchen den String in eine Zahl umzuwandeln 
            // sonst kommt es zu einer Fehlermeldung und Code wird nicht weiter ausgeführt
            if (lbl_navi_1.Visible == true)
            {
                if (txt_navi_netto1.Text != "" && txt_navi_brutto1.Text == "")
                {
                    try
                    {
                        zahln1 = Convert.ToDouble(txt_navi_netto1.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto1.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto1.Text != "" && txt_navi_netto1.Text == "")
                {
                    try
                    {
                        zahlb1 = Convert.ToDouble(txt_navi_brutto1.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto1.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto1.Text == "" && txt_navi_netto1.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto1.Text != "" && txt_navi_netto1.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto1.Clear();
                    txt_navi_brutto1.Clear();
                    return;
                }
            }

            if (lbl_navi_2.Visible == true)
            {
                if (txt_navi_netto2.Text != "" && txt_navi_brutto2.Text == "")
                {
                    try
                    {
                        zahln2 = Convert.ToDouble(txt_navi_netto2.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto2.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto2.Text != "" && txt_navi_netto2.Text == "")
                {
                    try
                    {
                        zahlb2 = Convert.ToDouble(txt_navi_brutto2.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto2.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto2.Text == "" && txt_navi_netto2.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto2.Text != "" && txt_navi_netto2.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto2.Clear();
                    txt_navi_brutto2.Clear();
                    return;
                }
            }

            if (lbl_navi_3.Visible == true)
            {
                if (txt_navi_netto3.Text != "" && txt_navi_brutto3.Text == "")
                {
                    try
                    {
                        zahln3 = Convert.ToDouble(txt_navi_netto3.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto3.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto3.Text != "" && txt_navi_netto3.Text == "")
                {
                    try
                    {
                        zahlb3 = Convert.ToDouble(txt_navi_brutto3.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto3.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto3.Text == "" && txt_navi_netto3.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto3.Text != "" && txt_navi_netto3.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto3.Clear();
                    txt_navi_brutto3.Clear();
                    return;
                }
            }

            if (lbl_navi_4.Visible == true)
            {
                if (txt_navi_netto4.Text != "" && txt_navi_brutto4.Text == "")
                {
                    try
                    {
                        zahln4 = Convert.ToDouble(txt_navi_netto4.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto4.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto4.Text != "" && txt_navi_netto4.Text == "")
                {
                    try
                    {
                        zahlb4 = Convert.ToDouble(txt_navi_brutto4.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto4.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto4.Text == "" && txt_navi_netto4.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto4.Text != "" && txt_navi_netto4.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto4.Clear();
                    txt_navi_brutto4.Clear();
                    return;
                }
            }

            if (lbl_navi_5.Visible == true)
            {
                if (txt_navi_netto5.Text != "" && txt_navi_brutto5.Text == "")
                {
                    try
                    {
                        zahln5 = Convert.ToDouble(txt_navi_netto5.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_netto5.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto5.Text != "" && txt_navi_netto5.Text == "")
                {
                    try
                    {
                        zahlb5 = Convert.ToDouble(txt_navi_brutto5.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                        txt_navi_brutto5.Clear();
                        return;
                    }
                }

                if (txt_navi_brutto5.Text == "" && txt_navi_netto5.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie Zahlenwerte ein");
                    return;
                }

                if (txt_navi_brutto5.Text != "" && txt_navi_netto5.Text != "")
                {
                    MessageBox.Show("Bitte füllen Sie nur einen der beiden Felder aus");
                    txt_navi_netto5.Clear();
                    txt_navi_brutto5.Clear();
                    return;
                }
            }

            if (cbo_navi_klasse1.SelectedIndex == 0)
            {

                // Wenn die Zahl 1 ungleich 0 ist, heißt das ich kann damit rechnen und dann wird
                // jeweils die fehlenden Werte berechnet
                if (zahln1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahle1 = zahln1 * 1.07;
                    }
                    else
                    {
                        zahle1 = zahln1 * 1.19;
                    }
                    zahlb1 = zahle1;
                    Math.Round(zahle1, 2);
                    txt_navi_brutto1.Text = zahle1.ToString("#0.00");
                }

                else if (zahlb1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahln1 = zahlb1 * 0.93;
                    }
                    else
                    {
                        zahln1 = zahlb1 * 0.81;
                    }
                    txt_navi_netto1.Text = zahln1.ToString("#0.00");
                    zahle1 = zahlb1;
                    Math.Round(zahle1, 2);
                }

                if (zahln2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahle2 = zahln2 * 1.07;
                    }
                    else
                    {
                        zahle2 = zahln2 * 1.19;
                    }
                    zahlb2 = zahle2;
                    Math.Round(zahle2, 2);
                    txt_navi_brutto2.Text = zahle2.ToString("#0.00");
                }

                else if (zahlb2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahln2 = zahlb2 * 0.93;
                    }
                    else
                    {
                        zahln2 = zahlb2 * 0.81;
                    }
                    txt_navi_netto2.Text = zahln2.ToString("#0.00");
                    zahle2 = zahlb2;
                    Math.Round(zahle2, 2);
                }

                if (zahln3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahle3 = zahln3 * 1.07;
                    }
                    else
                    {
                        zahle3 = zahln3 * 1.19;
                    }
                    zahlb3 = zahle3;
                    Math.Round(zahle3, 2);
                    txt_navi_brutto3.Text = zahle3.ToString("#0.00");
                }

                else if (zahlb3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahln3 = zahlb3 * 0.93;
                    }
                    else
                    {
                        zahln3 = zahlb3 * 0.81;
                    }
                    txt_navi_netto3.Text = zahln3.ToString("#0.00");
                    zahle3 = zahlb3;
                    Math.Round(zahle3, 2);
                }

                if (zahln4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahle4 = zahln4 * 1.07;
                    }
                    else
                    {
                        zahle4 = zahln4 * 1.19;
                    }
                    zahlb4 = zahle4;
                    Math.Round(zahle4, 2);
                    txt_navi_brutto4.Text = zahle4.ToString("#0.00");
                }

                else if (zahlb4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahln4 = zahlb4 * 0.93;
                    }
                    else
                    {
                        zahln4 = zahlb4 * 0.81;
                    }
                    txt_navi_netto4.Text = zahln4.ToString("#0.00");
                    zahle4 = zahlb4;
                    Math.Round(zahle4, 2);
                }

                if (zahln5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahle5 = zahln5 * 1.07;
                    }
                    else
                    {
                        zahle5 = zahln5 * 1.19;
                    }
                    zahlb5 = zahle5;
                    Math.Round(zahle5, 2);
                    txt_navi_brutto5.Text = zahle5.ToString("#0.00");
                }

                else if (zahlb5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahln5 = zahlb5 * 0.93;
                    }
                    else
                    {
                        zahln5 = zahlb5 * 0.81;
                    }
                    txt_navi_netto5.Text = zahln5.ToString("#0.00");
                    zahle5 = zahlb5;
                    Math.Round(zahle5, 2);
                }

            }


            if (cbo_navi_klasse1.SelectedIndex == 1)
            {

                if (zahln1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahlb1 = zahln1 * 1.07;
                    }
                    else
                    {
                        zahlb1 = zahln1 * 1.19;
                    }
                    Math.Round(zahlb1, 2);
                    txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.95;
                    Math.Round(zahle1, 2);
                }

                else if (zahlb1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahln1 = zahlb1 * 0.93;
                    }
                    else
                    {
                        zahln1 = zahlb1 * 0.81;
                    }
                    Math.Round(zahln1, 2);
                    txt_navi_netto1.Text = zahln1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.95;
                    Math.Round(zahle1, 2);
                }

                if (zahln2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahlb2 = zahln2 * 1.07;
                    }
                    else
                    {
                        zahlb2 = zahln2 * 1.19;
                    }
                    Math.Round(zahlb2, 2);
                    txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.95;
                    Math.Round(zahle2, 2);
                }

                else if (zahlb2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahln2 = zahlb2 * 0.93;
                    }
                    else
                    {
                        zahln2 = zahlb2 * 0.81;
                    }
                    Math.Round(zahln2, 2);
                    txt_navi_netto2.Text = zahln2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.95;
                    Math.Round(zahle2, 2);
                }

                if (zahln3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahlb3 = zahln3 * 1.07;
                    }
                    else
                    {
                        zahlb3 = zahln3 * 1.19;
                    }
                    Math.Round(zahlb3, 2);
                    txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.95;
                    Math.Round(zahle3, 2);
                }

                else if (zahlb3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahln3 = zahlb3 * 0.93;
                    }
                    else
                    {
                        zahln3 = zahlb3 * 0.81;
                    }
                    Math.Round(zahln3, 2);
                    txt_navi_netto3.Text = zahln3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.95;
                    Math.Round(zahle3, 2);
                }

                if (zahln4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahlb4 = zahln4 * 1.07;
                    }
                    else
                    {
                        zahlb4 = zahln4 * 1.19;
                    }
                    Math.Round(zahlb4, 2);
                    txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.95;
                    Math.Round(zahle4, 2);
                }

                else if (zahlb4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahln4 = zahlb4 * 0.93;
                    }
                    else
                    {
                        zahln4 = zahlb4 * 0.81;
                    }
                    Math.Round(zahln4, 2);
                    txt_navi_netto4.Text = zahln4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.95;
                    Math.Round(zahle4, 2);
                }

                if (zahln5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahlb5 = zahln5 * 1.07;
                    }
                    else
                    {
                        zahlb5 = zahln5 * 1.19;
                    }
                    Math.Round(zahlb5, 2);
                    txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.95;
                    Math.Round(zahle5, 2);
                }

                else if (zahlb5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahln5 = zahlb5 * 0.93;
                    }
                    else
                    {
                        zahln5 = zahlb5 * 0.81;
                    }
                    Math.Round(zahln5, 2);
                    txt_navi_netto5.Text = zahln5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.95;
                    Math.Round(zahle5, 2);
                }

            }


            if (cbo_navi_klasse1.SelectedIndex == 2)
            {
                if (zahln1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahlb1 = zahln1 * 1.07;
                    }
                    else
                    {
                        zahlb1 = zahln1 * 1.19;
                    }
                    Math.Round(zahlb1, 2);
                    txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.9;
                    Math.Round(zahle1, 2);
                }

                else if (zahlb1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahln1 = zahlb1 * 0.93;
                    }
                    else
                    {
                        zahln1 = zahlb1 * 0.81;
                    }
                    Math.Round(zahln1, 2);
                    txt_navi_netto1.Text = zahln1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.9;
                    Math.Round(zahle1, 2);
                }

                if (zahln2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahlb2 = zahln2 * 1.07;
                    }
                    else
                    {
                        zahlb2 = zahln2 * 1.19;
                    }
                    Math.Round(zahlb2, 2);
                    txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.9;
                    Math.Round(zahle2, 2);
                }

                else if (zahlb2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahln2 = zahlb2 * 0.93;
                    }
                    else
                    {
                        zahln2 = zahlb2 * 0.81;
                    }
                    Math.Round(zahln2, 2);
                    txt_navi_netto2.Text = zahln2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.9;
                    Math.Round(zahle2, 2);
                }

                if (zahln3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahlb3 = zahln3 * 1.07;
                    }
                    else
                    {
                        zahlb3 = zahln3 * 1.19;
                    }
                    Math.Round(zahlb3, 2);
                    txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.9;
                    Math.Round(zahle3, 2);
                }

                else if (zahlb3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahln3 = zahlb3 * 0.93;
                    }
                    else
                    {
                        zahln3 = zahlb3 * 0.81;
                    }
                    Math.Round(zahln3, 2);
                    txt_navi_netto3.Text = zahln3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.9;
                    Math.Round(zahle3, 2);
                }

                if (zahln4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahlb4 = zahln4 * 1.07;
                    }
                    else
                    {
                        zahlb4 = zahln4 * 1.19;
                    }
                    Math.Round(zahlb4, 2);
                    txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.9;
                    Math.Round(zahle4, 2);
                }

                else if (zahlb4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahln4 = zahlb4 * 0.93;
                    }
                    else
                    {
                        zahln4 = zahlb4 * 0.81;
                    }
                    Math.Round(zahln4, 2);
                    txt_navi_netto4.Text = zahln4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.9;
                    Math.Round(zahle4, 2);
                }

                if (zahln5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahlb5 = zahln5 * 1.07;
                    }
                    else
                    {
                        zahlb5 = zahln5 * 1.19;
                    }
                    Math.Round(zahlb5, 2);
                    txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.9;
                    Math.Round(zahle5, 2);
                }

                else if (zahlb5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahln5 = zahlb5 * 0.93;
                    }
                    else
                    {
                        zahln5 = zahlb5 * 0.81;
                    }
                    Math.Round(zahln5, 2);
                    txt_navi_netto5.Text = zahln5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.9;
                    Math.Round(zahle5, 2);
                }
            }
            if (cbo_navi_klasse1.SelectedIndex == 3)
            {
                if (zahln1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahlb1 = zahln1 * 1.07;
                    }
                    else
                    {
                        zahlb1 = zahln1 * 1.19;
                    }
                    Math.Round(zahlb1, 2);
                    txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.85;
                    Math.Round(zahle1, 2);
                }

                else if (zahlb1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahln1 = zahlb1 * 0.93;
                    }
                    else
                    {
                        zahln1 = zahlb1 * 0.81;
                    }
                    Math.Round(zahln1, 2);
                    txt_navi_netto1.Text = zahln1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.85;
                    Math.Round(zahle1, 2);
                }

                if (zahln2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahlb2 = zahln2 * 1.07;
                    }
                    else
                    {
                        zahlb2 = zahln2 * 1.19;
                    }
                    Math.Round(zahlb2, 2);
                    txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.85;
                    Math.Round(zahle2, 2);
                }

                else if (zahlb2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahln2 = zahlb2 * 0.93;
                    }
                    else
                    {
                        zahln2 = zahlb2 * 0.81;
                    }
                    Math.Round(zahln2, 2);
                    txt_navi_netto2.Text = zahln2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.85;
                    Math.Round(zahle2, 2);
                }

                if (zahln3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahlb3 = zahln3 * 1.07;
                    }
                    else
                    {
                        zahlb3 = zahln3 * 1.19;
                    }
                    Math.Round(zahlb3, 2);
                    txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.85;
                    Math.Round(zahle3, 2);
                }

                else if (zahlb3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahln3 = zahlb3 * 0.93;
                    }
                    else
                    {
                        zahln3 = zahlb3 * 0.81;
                    }
                    Math.Round(zahln3, 2);
                    txt_navi_netto3.Text = zahln3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.85;
                    Math.Round(zahle3, 2);
                }

                if (zahln4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahlb4 = zahln4 * 1.07;
                    }
                    else
                    {
                        zahlb4 = zahln4 * 1.19;
                    }
                    Math.Round(zahlb4, 2);
                    txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.85;
                    Math.Round(zahle4, 2);
                }

                else if (zahlb4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahln4 = zahlb4 * 0.93;
                    }
                    else
                    {
                        zahln4 = zahlb4 * 0.81;
                    }
                    Math.Round(zahln4, 2);
                    txt_navi_netto4.Text = zahln4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.85;
                    Math.Round(zahle4, 2);
                }

                if (zahln5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahlb5 = zahln5 * 1.07;
                    }
                    else
                    {
                        zahlb5 = zahln5 * 1.19;
                    }
                    Math.Round(zahlb5, 2);
                    txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.85;
                    Math.Round(zahle5, 2);
                }

                else if (zahlb5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahln5 = zahlb5 * 0.93;
                    }
                    else
                    {
                        zahln5 = zahlb5 * 0.81;
                    }
                    Math.Round(zahln5, 2);
                    txt_navi_netto5.Text = zahln5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.85;
                    Math.Round(zahle5, 2);
                }
            }

            if (cbo_navi_klasse1.SelectedIndex == 4)
            {


                if (zahln1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahlb1 = zahln1 * 1.07;
                    }
                    else
                    {
                        zahlb1 = zahln1 * 1.19;
                    }
                    Math.Round(zahlb1, 2);
                    txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.8;
                    Math.Round(zahle1, 2);
                }

                else if (zahlb1 != 0)
                {
                    if (cbo_navi_klasse1.SelectedIndex == 0)
                    {
                        zahln1 = zahlb1 * 0.93;
                    }
                    else
                    {
                        zahln1 = zahlb1 * 0.81;
                    }
                    Math.Round(zahln1, 2);
                    txt_navi_netto1.Text = zahln1.ToString("#0.00");
                    zahle1 = zahlb1 * 0.8;
                    Math.Round(zahle1, 2);
                }

                if (zahln2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahlb2 = zahln2 * 1.07;
                    }
                    else
                    {
                        zahlb2 = zahln2 * 1.19;
                    }
                    Math.Round(zahlb2, 2);
                    txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.8;
                    Math.Round(zahle2, 2);
                }

                else if (zahlb2 != 0)
                {
                    if (cbo_navi_klasse2.SelectedIndex == 0)
                    {
                        zahln2 = zahlb2 * 0.93;
                    }
                    else
                    {
                        zahln2 = zahlb2 * 0.81;
                    }
                    Math.Round(zahln2, 2);
                    txt_navi_netto2.Text = zahln2.ToString("#0.00");
                    zahle2 = zahlb2 * 0.8;
                    Math.Round(zahle2, 2);
                }

                if (zahln3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahlb3 = zahln3 * 1.07;
                    }
                    else
                    {
                        zahlb3 = zahln3 * 1.19;
                    }
                    Math.Round(zahlb3, 2);
                    txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.8;
                    Math.Round(zahle3, 2);
                }

                else if (zahlb3 != 0)
                {
                    if (cbo_navi_klasse3.SelectedIndex == 0)
                    {
                        zahln3 = zahlb3 * 0.93;
                    }
                    else
                    {
                        zahln3 = zahlb3 * 0.81;
                    }
                    Math.Round(zahln3, 2);
                    txt_navi_netto3.Text = zahln3.ToString("#0.00");
                    zahle3 = zahlb3 * 0.8;
                    Math.Round(zahle3, 2);
                }

                if (zahln4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahlb4 = zahln4 * 1.07;
                    }
                    else
                    {
                        zahlb4 = zahln4 * 1.19;
                    }
                    Math.Round(zahlb4, 2);
                    txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.8;
                    Math.Round(zahle4, 2);
                }

                else if (zahlb4 != 0)
                {
                    if (cbo_navi_klasse4.SelectedIndex == 0)
                    {
                        zahln4 = zahlb4 * 0.93;
                    }
                    else
                    {
                        zahln4 = zahlb4 * 0.81;
                    }
                    Math.Round(zahln4, 2);
                    txt_navi_netto4.Text = zahln4.ToString("#0.00");
                    zahle4 = zahlb4 * 0.8;
                    Math.Round(zahle4, 2);
                }

                if (zahln5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahlb5 = zahln5 * 1.07;
                    }
                    else
                    {
                        zahlb5 = zahln5 * 1.19;
                    }
                    Math.Round(zahlb5, 2);
                    txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.8;
                    Math.Round(zahle5, 2);
                }

                else if (zahlb5 != 0)
                {
                    if (cbo_navi_klasse5.SelectedIndex == 0)
                    {
                        zahln5 = zahlb5 * 0.93;
                    }
                    else
                    {
                        zahln5 = zahlb5 * 0.81;
                    }
                    Math.Round(zahln5, 2);
                    txt_navi_netto5.Text = zahln5.ToString("#0.00");
                    zahle5 = zahlb5 * 0.8;
                    Math.Round(zahle5, 2);
                }

                if (cbo_navi_klasse1.SelectedIndex == 5)
                {

                    try
                    {
                        zahlrabatt = Convert.ToDouble(txt_navi_rabatt.Text);
                    }

                    catch
                    {
                        MessageBox.Show("Bitte geben Sie einen beliebige Rabatt ein");
                        txt_navi_rabatt.Clear();
                        return;
                    }

                    if (zahlrabatt < 0 || zahlrabatt > 100)
                    {
                        MessageBox.Show("Bitte geben Sie einen Zahlwert größer 0 und kleiner 100 ein");
                        txt_navi_rabatt.Clear();
                        return;
                    }

                    if (zahln1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahlb1 = zahln1 * 1.07;
                        }
                        else
                        {
                            zahlb1 = zahln1 * 1.19;
                        }
                        Math.Round(zahlb1, 2);
                        txt_navi_brutto1.Text = zahlb1.ToString("#0.00");
                        zahle1 = zahlb1 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle1, 2);
                    }

                    else if (zahlb1 != 0)
                    {
                        if (cbo_navi_klasse1.SelectedIndex == 0)
                        {
                            zahln1 = zahlb1 * 0.93;
                        }
                        else
                        {
                            zahln1 = zahlb1 * 0.81;
                        }
                        Math.Round(zahln1, 2);
                        txt_navi_netto1.Text = zahln1.ToString("#0.00");
                        zahle1 = zahlb1 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle1, 2);
                    }

                    if (zahln2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahlb2 = zahln2 * 1.07;
                        }
                        else
                        {
                            zahlb2 = zahln2 * 1.19;
                        }
                        Math.Round(zahlb2, 2);
                        txt_navi_brutto2.Text = zahlb2.ToString("#0.00");
                        zahle2 = zahlb2 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle2, 2);
                    }

                    else if (zahlb2 != 0)
                    {
                        if (cbo_navi_klasse2.SelectedIndex == 0)
                        {
                            zahln2 = zahlb2 * 0.93;
                        }
                        else
                        {
                            zahln2 = zahlb2 * 0.81;
                        }
                        Math.Round(zahln2, 2);
                        txt_navi_netto2.Text = zahln2.ToString("#0.00");
                        zahle2 = zahlb2 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle2, 2);
                    }

                    if (zahln3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahlb3 = zahln3 * 1.07;
                        }
                        else
                        {
                            zahlb3 = zahln3 * 1.19;
                        }
                        Math.Round(zahlb3, 2);
                        txt_navi_brutto3.Text = zahlb3.ToString("#0.00");
                        zahle3 = zahlb3 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle3, 2);
                    }

                    else if (zahlb3 != 0)
                    {
                        if (cbo_navi_klasse3.SelectedIndex == 0)
                        {
                            zahln3 = zahlb3 * 0.93;
                        }
                        else
                        {
                            zahln3 = zahlb3 * 0.81;
                        }
                        Math.Round(zahln3, 2);
                        txt_navi_netto3.Text = zahln3.ToString("#0.00");
                        zahle3 = zahlb3 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle3, 2);
                    }

                    if (zahln4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahlb4 = zahln4 * 1.07;
                        }
                        else
                        {
                            zahlb4 = zahln4 * 1.19;
                        }
                        Math.Round(zahlb4, 2);
                        txt_navi_brutto4.Text = zahlb4.ToString("#0.00");
                        zahle4 = zahlb4 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle4, 2);
                    }

                    else if (zahlb4 != 0)
                    {
                        if (cbo_navi_klasse4.SelectedIndex == 0)
                        {
                            zahln4 = zahlb4 * 0.93;
                        }
                        else
                        {
                            zahln4 = zahlb4 * 0.81;
                        }
                        Math.Round(zahln4, 2);
                        txt_navi_netto4.Text = zahln4.ToString("#0.00");
                        zahle4 = zahlb4 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle4, 2);
                    }

                    if (zahln5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahlb5 = zahln5 * 1.07;
                        }
                        else
                        {
                            zahlb5 = zahln5 * 1.19;
                        }
                        Math.Round(zahlb5, 2);
                        txt_navi_brutto5.Text = zahlb5.ToString("#0.00");
                        zahle5 = zahlb5 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle5, 2);
                    }

                    else if (zahlb5 != 0)
                    {
                        if (cbo_navi_klasse5.SelectedIndex == 0)
                        {
                            zahln5 = zahlb5 * 0.93;
                        }
                        else
                        {
                            zahln5 = zahlb5 * 0.81;
                        }
                        Math.Round(zahln5, 2);
                        txt_navi_netto5.Text = zahln5.ToString("#0.00");
                        zahle5 = zahlb5 * (1 - (zahlrabatt / 100));
                        Math.Round(zahle5, 2);
                    }

                    MessageBox.Show("Bitte wählen Sie die angezeigten Rabattaktionen aus");
                    cbo_navi_rabatt.Text = "Rabattaktion";
                    return;
                }
            }

            // Picture/Label und Button ein- und ausblenden
            pic_navi_end.Visible = true;
            lbl_navi_end.Visible = true;

            btn_navi_berechnen_if.Visible = false;
            btn_navi_berechnen_switch.Visible = false;
        }

        private void txt_navi_netto1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
