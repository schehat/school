using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{

    public partial class Spiel : Form
    {

        bool maxcheck = false;
        bool color = true;
        string cross = "X";
        string circle = "O";
        string player1 = "", player2 = "";
        int win1, win2 = 0;

        public Spiel()
        {
            InitializeComponent();
        }

        private void picMinStart_Click(object sender, EventArgs e)
        {
            //minimieren
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaxStart_Click(object sender, EventArgs e)
        {
            // Fenster maximieren
            if (maxcheck == false)
            {
                this.WindowState = FormWindowState.Maximized;
                maxcheck = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxcheck = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Programm beenden
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spiel_Load(object sender, EventArgs e)
        {

        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            if (txtplayer1.Text != "" && txtplayer2.Text != "")
            {
                lbl1.Enabled = true;
                lbl2.Enabled = true;
                lbl3.Enabled = true;
                lbl4.Enabled = true;
                lbl5.Enabled = true;
                lbl6.Enabled = true;
                lbl7.Enabled = true;
                lbl8.Enabled = true;
                lbl9.Enabled = true;
                picplay.Visible = true;
                lblstart.Visible = false;
                lblstart.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie Spielernamen an", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblnew_Click(object sender, EventArgs e)
        {
            lblwinner1.Visible = false;
            lblwinner2.Visible = false;
            lblwinner1.Text = "";
            lblwinner2.Text = "";
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl1.BackColor = Color.FromArgb(255, 255, 192);
            lbl2.BackColor = Color.FromArgb(255, 255, 192);
            lbl3.BackColor = Color.FromArgb(255, 255, 192);
            lbl4.BackColor = Color.FromArgb(255, 255, 192);
            lbl5.BackColor = Color.FromArgb(255, 255, 192);
            lbl6.BackColor = Color.FromArgb(255, 255, 192);
            lbl7.BackColor = Color.FromArgb(255, 255, 192);
            lbl8.BackColor = Color.FromArgb(255, 255, 192);
            lbl9.BackColor = Color.FromArgb(255, 255, 192);
            lbl1.Enabled = false;
            lbl2.Enabled = false;
            lbl3.Enabled = false;
            lbl4.Enabled = false;
            lbl5.Enabled = false;
            lbl6.Enabled = false;
            lbl7.Enabled = false;
            lbl8.Enabled = false;
            lbl9.Enabled = false;
            lblnew.Visible = false;
            lblnew.Enabled = false;
            lblstart.Visible = true;
            lblstart.Enabled = true;
            picplay.Visible = false;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            player1 = txtplayer1.Text;
            player2 = txtplayer2.Text;

            if (color == true)
            {
                label.Text = cross;
                label.BackColor = Color.Red;
                color = false;
                label.Enabled = false;
            }
            else
            {
                label.Text = circle;
                label.BackColor = Color.Blue;
                color = true;
                label.Enabled = false;
            }

            if ((lbl1.Text == cross && lbl2.Text == cross && lbl3.Text == cross) ||
                (lbl4.Text == cross && lbl5.Text == cross && lbl6.Text == cross) ||
                (lbl7.Text == cross && lbl8.Text == cross && lbl9.Text == cross) ||
                (lbl1.Text == cross && lbl4.Text == cross && lbl7.Text == cross) ||
                (lbl2.Text == cross && lbl5.Text == cross && lbl8.Text == cross) ||
                (lbl3.Text == cross && lbl6.Text == cross && lbl9.Text == cross) ||
                (lbl1.Text == cross && lbl5.Text == cross && lbl9.Text == cross) ||
                (lbl3.Text == cross && lbl5.Text == cross && lbl7.Text == cross)
                )
            {
                lblwinner1.Text = player1 + " hat gewonnen";
                lblwinner1.Visible = true;
                lblnew.Visible = true;
                lblnew.Enabled = true;
                lblstart.Visible = false;
                lblstart.Enabled = false;
                lbl1.Enabled = false;
                lbl2.Enabled = false;
                lbl3.Enabled = false;
                lbl4.Enabled = false;
                lbl5.Enabled = false;
                lbl6.Enabled = false;
                lbl7.Enabled = false;
                lbl8.Enabled = false;
                lbl9.Enabled = false;
                win1++;
                lblcount1.Text = "Siege: " + win1;
                lblcount1.Visible = true;
                lblcount2.Text = "Siege: " + win2;
                lblcount2.Visible = true;
            }

            else if ((lbl1.Text == circle && lbl2.Text == circle && lbl3.Text == circle) ||
                (lbl4.Text == circle && lbl5.Text == circle && lbl6.Text == circle) ||
                (lbl7.Text == circle && lbl8.Text == circle && lbl9.Text == circle) ||
                (lbl1.Text == circle && lbl4.Text == circle && lbl7.Text == circle) ||
                (lbl2.Text == circle && lbl5.Text == circle && lbl8.Text == circle) ||
                (lbl3.Text == circle && lbl6.Text == circle && lbl9.Text == circle) ||
                (lbl1.Text == circle && lbl5.Text == circle && lbl9.Text == circle) ||
                (lbl3.Text == circle && lbl5.Text == circle && lbl7.Text == circle))
            {
                lblwinner2.Text = player2 + " hat gewonnen";
                lblwinner2.Visible = true;
                lblnew.Visible = true;
                lblnew.Enabled = true;
                lblstart.Visible = false;
                lblstart.Enabled = false;
                lbl1.Enabled = false;
                lbl2.Enabled = false;
                lbl3.Enabled = false;
                lbl4.Enabled = false;
                lbl5.Enabled = false;
                lbl6.Enabled = false;
                lbl7.Enabled = false;
                lbl8.Enabled = false;
                lbl9.Enabled = false;
                win2++;
                lblcount1.Text = "Siege: " + win1;
                lblcount2.Text = "Siege: " + win2;
                lblcount1.Visible = true;
                lblcount2.Visible = true;
            }

            if ((lbl1.Text != "" && lbl2.Text != "" && lbl3.Text != "" && lbl4.Text != "" && lbl5.Text != ""
                && lbl6.Text != "" && lbl7.Text != "" && lbl8.Text != "" && lbl9.Text != "" && (lblwinner1.Text == "" || lblwinner1.Text == "")))
            {
                lblwinner1.Visible = true;
                lblwinner2.Visible = true;
                lblwinner1.Text = "niemand hat gewonnen";
                lblwinner2.Text = "niemand hat gewonnen";
                lblnew.Visible = true;
                lblnew.Enabled = true;
                lblstart.Visible = false;
                lblstart.Enabled = false;
                lblcount1.Text = "Siege: " + win1;
                lblcount2.Text = "Siege: " + win2;
                lblcount1.Visible = true;
                lblcount2.Visible = true;
            }
            }
        }
    }
