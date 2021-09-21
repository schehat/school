using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_Nr._5
{
    public partial class Form1 : Form
    {
        // Variablen deklarieren und initilalisieren
        double a = 0, b = 0, c = 0, alpha_deg = 0, alpha_rad = 0, beta_deg = 0, beta_rad = 0, gamma_deg = 0, gamma_rad = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_start_intro_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_rechtwinklig_MouseHover(object sender, EventArgs e)
        {
            // Layer wechsenln
            grp_start.Visible = false;
            grp_screen_rechtwinklig.Visible = true;
        }

        private void btn_start_beliebig_MouseHover(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_start.Visible = false;
            
        }

        private void grp_screen_rechtwinklig_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_rechtwinklig_intro_Click(object sender, EventArgs e)
        {

        }

        private void txt_rechtwinklig_seite_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rechtwinklig_rechnen_MouseHover(object sender, EventArgs e)
        {
            // Fehlersuche
            try
            {
                {
                    // Überprüfen ob der leer ist
                    if (txt_rechtwinklig_seite_a.Text != "")
                    {
                        //  Punkt mit Komma ersetzen und Text in Zahl konventieren
                        txt_rechtwinklig_seite_a.Text = txt_rechtwinklig_seite_a.Text.Replace(".", ",");
                        a = Convert.ToDouble(txt_rechtwinklig_seite_a.Text);

                        // Grenzwert 
                        if (a > 99000)
                        {
                            // Ausgabe
                            MessageBox.Show("Bitte geben Sie Zahlenwerte unter dem Grenzwert von 99.000 ein");
                            // leeren
                            txt_rechtwinklig_seite_a.Text = "";
                            // Methode beenden
                            return;
                        }

                        if (a <= 0)
                        {
                            if (txt_rechtwinklig_seite_a.Text == "")
                            {
                                MessageBox.Show("Bitte geben Sie Zahlenwerte über 0 ein");
                                txt_rechtwinklig_seite_a.Text = "";
                                return;
                            }
                        }
                    }
                }
            }
            // Wenn der Code oben nicht ausgeführt werden kann, weil der Text nicht als Zahl konventiert werden kann
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte ein");
                txt_rechtwinklig_seite_a.Text = "";
                return;
            }

            try
            {
                if (txt_rechtwinklig_seite_a.Text != "")
                {
                    txt_rechtwinklig_seite_b.Text = txt_rechtwinklig_seite_b.Text.Replace(".", ",");
                    b = Convert.ToDouble(txt_rechtwinklig_seite_b.Text);

                    if (b > 99000)
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte unter dem Grenzwert von 99.000 ein");
                        txt_rechtwinklig_seite_b.Text = "";
                        return;
                    }

                    else if (b <= 0)
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte über 0 ein");
                        txt_rechtwinklig_seite_b.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte ein");
                txt_rechtwinklig_seite_b.Text = "";
                return;
            }

            try
            {
                if (txt_rechtwinklig_seite_c.Text != "")
                {
                    txt_rechtwinklig_seite_c.Text = txt_rechtwinklig_seite_c.Text.Replace(".", ",");
                    c = Convert.ToDouble(txt_rechtwinklig_seite_c.Text);

                    if (c > 99000)
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte unter dem Grenzwert von 99.000 ein");
                        txt_rechtwinklig_seite_c.Text = "";
                        return;
                    }

                    else if (c <= 0)
                    {
                        MessageBox.Show("Bitte geben Sie Zahlenwerte über 0 ein");
                        txt_rechtwinklig_seite_c.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte ein");
                txt_rechtwinklig_seite_c.Text = "";
                return;
            }

            try
            {
                if (txt_rechtwinklig_winkel_alpha.Text != "")
                {
                    txt_rechtwinklig_winkel_alpha.Text = txt_rechtwinklig_winkel_alpha.Text.Replace(".", ",");
                    alpha_deg = Convert.ToDouble(txt_rechtwinklig_winkel_alpha.Text);

                    if (alpha_deg > 90)
                    {
                        MessageBox.Show("Bitte geben Sie maximal einen Winkel von 90° ein");
                        txt_rechtwinklig_winkel_alpha.Text = "";
                        return;
                    }

                    else if (alpha_deg <= 0)
                    {
                        MessageBox.Show("Bitte geben Sie einen Winkel von über 0° ein");
                        txt_rechtwinklig_winkel_alpha.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte als Winkel ein");
                txt_rechtwinklig_winkel_alpha.Text = "";
                return;
            }

            try
            {
                if (txt_rechtwinklig_winkel_beta.Text != "")
                {
                    txt_rechtwinklig_winkel_beta.Text = txt_rechtwinklig_winkel_beta.Text.Replace(".", ",");
                    beta_deg = Convert.ToDouble(txt_rechtwinklig_winkel_beta.Text);

                    if (beta_deg > 90)
                    {
                        MessageBox.Show("Bitte geben Sie maximal einen Winkel von 90° ein");
                        txt_rechtwinklig_winkel_beta.Text = "";
                        return;
                    }

                    else if (beta_deg <= 0)
                    {
                        MessageBox.Show("Bitte geben Sie einen Winkel von über 0° ein");
                        txt_rechtwinklig_winkel_beta.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte als Winkel ein");
                txt_rechtwinklig_winkel_beta.Text = "";
                return;
            }

            try
            {
                if (txt_rechtwinklig_winkel_gamma.Text != "")
                {
                    txt_rechtwinklig_winkel_gamma.Text = txt_rechtwinklig_winkel_gamma.Text.Replace(".", ",");
                    gamma_deg = Convert.ToDouble(txt_rechtwinklig_winkel_gamma.Text);

                    if (gamma_deg > 90)
                    {
                        MessageBox.Show("Bitte geben Sie maximal einen Winkel von 90° ein");
                        txt_rechtwinklig_winkel_gamma.Text = "";
                        return;
                    }

                    else if (gamma_deg <= 0)
                    {
                        MessageBox.Show("Bitte geben Sie einen Winkel von über 0° ein");
                        txt_rechtwinklig_winkel_gamma.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie nur Zahlenwerte als Winkel ein");
                txt_rechtwinklig_winkel_gamma.Text = "";
                return;
            }

            if (alpha_deg + beta_deg + gamma_deg > 180)
            {
                MessageBox.Show("Die Summer der Winkel kann nicht 180° überschreiten");
                txt_rechtwinklig_winkel_alpha.Text = "";
                txt_rechtwinklig_winkel_beta.Text = "";
                txt_rechtwinklig_winkel_gamma.Text = "";
            }

            if (alpha_deg + beta_deg > 90)
            {
                MessageBox.Show("Die Summe beider Winkel alpha und beta dürfen nicht größer als 90° ergeben");
                txt_rechtwinklig_winkel_alpha.Text = "";
                txt_rechtwinklig_winkel_beta.Text = "";
                return;
            }
            else if (alpha_deg + gamma_deg > 90)
            {
                MessageBox.Show("Die Summe beider Winkel alpha und gamma dürfen nicht größer als 90° ergeben");
                txt_rechtwinklig_winkel_alpha.Text = "";
                txt_rechtwinklig_winkel_gamma.Text = "";
                return;
            }
            else if (beta_deg + gamma_deg > 90)
            {
                MessageBox.Show("Die Summe beider Winkel beta und gamma dürfen nicht größer als 90° ergeben");
                txt_rechtwinklig_winkel_beta.Text = "";
                txt_rechtwinklig_winkel_gamma.Text = "";
                return;
            }
        }

        private void btn_start_rechtwinklig_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_rechtwinklig_winkel_alpha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_rechtwinklig_winkel_alpha_Click(object sender, EventArgs e)
        {

        }

        private void txt_rechtwinklig_seite_a_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_rechtwinklig_zurueck_Click(object sender, EventArgs e)
        {
            // Layer Wechseln
            grp_start.Visible = true;
            grp_screen_rechtwinklig.Visible = false;
        }

        private void btn_rechtwinklig_zurueck_MouseHover(object sender, EventArgs e)
        {
            // Layer wechseln
            grp_start.Visible = true;
            grp_screen_rechtwinklig.Visible = false;
        }

        private void btn_rechtwinklig_rechnen_Click(object sender, EventArgs e)
        {

        }
    }
}
