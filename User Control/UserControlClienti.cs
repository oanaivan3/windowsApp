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
    public partial class UserControlClienti : UserControl
    {
        private string ID = "";
        private List<ClientInfo> clientiList = new List<ClientInfo>();
        public class ClientInfo
        {
            public string NumeFamilie { get; set; }
            public string Prenume { get; set; }
            public string CodClient { get; set; }
            public string AdresaClient { get; set; }
        }
        public UserControlClienti()
        {
            InitializeComponent();
        }

        private void AdaugaDateInLista(string numeFamilie, string prenume, string codClient, string adresaClient)
        {
            ClientInfo client = new ClientInfo
            {
                NumeFamilie = numeFamilie,
                Prenume = prenume,
                CodClient = codClient,
                AdresaClient = adresaClient
            };
            clientiList.Add(client);
        }

        private void ActualizeazaDataGridView()
        {
            dataGridViewClient.Rows.Clear();
            foreach (var client in clientiList)
            {
                dataGridViewClient.Rows.Add(client.NumeFamilie, client.Prenume, client.CodClient, client.AdresaClient);
            }
        }

        public void Clear()
        {
            textBoxNumeFamilie.Clear();
            textBoxPrenume.Clear();
            textBoxCodClient.Clear();
            textBoxAdresaClient.Clear();
            tabControlClienti.SelectedTab = tabPageAdaugaClient;
        }

        private void Clear1()
        {
            textBoxNumeFamilie1.Clear();
            textBoxPrenume1.Clear();
            textBoxCodClient1.Clear();
            textBoxAdresaClient1.Clear();
            ID = "";
        }

        private void buttonAdaugaClient_Click(object sender, EventArgs e)
        {
  
            if (textBoxNumeFamilie.Text.Trim() == string.Empty ||
                textBoxPrenume.Text.Trim() == string.Empty ||
                textBoxCodClient.Text.Trim() == string.Empty ||
                textBoxAdresaClient.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Te rog completează toate câmpurile", "Sunt necesare toate câmpurile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AdaugaDateInLista(textBoxNumeFamilie.Text, textBoxPrenume.Text, textBoxCodClient.Text, textBoxAdresaClient.Text);
            ActualizeazaDataGridView(); 
        }

        private void tabPageAdaugaClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageCautaClient_Enter(object sender, EventArgs e)
        {
            textBoxCautaCodClient.Clear();
        }

        private void tabPageCautaClient_Leave(object sender, EventArgs e)
        {
            textBoxCautaCodClient.Clear();
        }

        private void buttonActualizeaza_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID!="")
            {
                if (textBoxNumeFamilie1.Text.Trim() == string.Empty || textBoxPrenume1.Text.Trim() == string.Empty || textBoxCodClient1.Text.Trim() == string.Empty || textBoxAdresaClient1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Te rog completeaza toate campurile", "Sunt necesare toate campurile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxNumeFamilie1.Text.Trim() == string.Empty || textBoxPrenume1.Text.Trim() == string.Empty || textBoxCodClient1.Text.Trim() == string.Empty || textBoxAdresaClient1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Te rog completeaza toate campurile", "Sunt necesare toate campurile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Sigur vrei sa stergi acest client?", "Stergere client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void tabPageActualizeazaSiStergeClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxNumeFamilie1.Text = row.Cells[1].Value.ToString();
                textBoxPrenume1.Text = row.Cells[2].Value.ToString();
                textBoxCodClient1.Text = row.Cells[3].Value.ToString();
                textBoxAdresaClient1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewCell cell = dataGridViewClient.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    string cellValue = cell.Value.ToString();
                    MessageBox.Show("Valoarea din celulă: " + cellValue);

                }
            }
        }

        private void tabPageAdaugaClient_Click(object sender, EventArgs e)
        {

        }
    }
}
