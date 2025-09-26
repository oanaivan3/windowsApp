using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_IvanOanaGeorgiana
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel (Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelDelogare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            this.Close();
            DialogResult result = MessageBox.Show("Doresti sa te deloghezi?", "Delogare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void buttonClienti_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClienti);
            userControlClienti1.Clear();
            userControlClienti1.Show();
        }

        private void buttonComenzi_Click(object sender, EventArgs e)
        {
            MovePanel(buttonComenzi);
            userControlClienti1.Hide();

        }

        private void buttonFacturi_Click(object sender, EventArgs e)
        {
            MovePanel(buttonFacturi);
            userControlClienti1.Hide();

        }

        private void userControlClienti1_Load(object sender, EventArgs e)
        {

        }
    }
}
