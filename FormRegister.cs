using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PAW_IvanOanaGeorgiana
{
    public partial class FormRegister : Form
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=193.226.34.57)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orclpdb.docker.internal)));User Id=DUMITRUS_43;Password=stud;";

        public FormRegister()
        {
            InitializeComponent();
            textBox5.PasswordChar = '*';
            textBox3.KeyPress += new KeyPressEventHandler(textBox3_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string nrTelefon = textBox3.Text;
            string mail = textBox4.Text;
            string parola = textBox5.Text;


            if (string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Numele trebuie completat.");
                return;
            }
            if (string.IsNullOrWhiteSpace(prenume))
            {
                MessageBox.Show("Prenumele trebuie completat.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nrTelefon))
            {
                MessageBox.Show("Numărul de telefon trebuie completat.");
                return;
            }
            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Mailul trebuie completat.");
                return;
            }
            if (!mail.Contains("@"))
            {
                MessageBox.Show("Adresă invalidă.");
                return;
            }
            if (string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Parola trebuie completată.");
                return;
            }
  


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            AdaugaClient(nume, prenume, nrTelefon, mail, parola);
            this.Close();
        }

        private void AdaugaClient(string nume, string prenume, string nrTelefon, string mail, string parola)
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("INSERT INTO UTILIZATORIAPLICATIE (Nume, Prenume, NrTelefon, Mail, Parola) VALUES (:nume, :prenume, :nrTelefon, :mail, :parola)", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("nume", nume));
                    cmd.Parameters.Add(new OracleParameter("prenume", prenume));
                    cmd.Parameters.Add(new OracleParameter("nrTelefon", nrTelefon));
                    cmd.Parameters.Add(new OracleParameter("mail", mail));
                    cmd.Parameters.Add(new OracleParameter("parola", parola));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
