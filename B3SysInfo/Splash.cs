using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loading_screen
{
    public partial class Splash : Form
    {
        List<Color> colors = new List<Color>();
        public Splash()
        {
            colors.Add(Color.FromArgb(0, 158, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 42));
            colors.Add(Color.FromArgb(217, 102, 42));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));




            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BunifuClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        int curcolor = 0;
        int loop = 0;

        private void fader_Tick(object sender, EventArgs e)
        {
            fader.Enabled = false;
            if (curcolor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, colors[curcolor], colors[curcolor + 1]);
                if (loop < 10)
                {
                    loop++;
                }
                else
                {
                    loop = 0;
                    curcolor++;
                }
                fader.Enabled = true;
            }
            else
            {
                NextShow();
                // MessageBox.Show("Complete.");
            }
        

        }

        private void Splash_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("clicked");
            NextShow();
        }

        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                System.Diagnostics.Debug.WriteLine("Escape");
                NextShow();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("clicked");
            NextShow();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            NextShow();
        }
        private void NextShow()
        {
            this.Hide();
            MainForm B3main = new MainForm();
            B3main.ShowDialog();
            Application.Exit();
        }
    }
}
