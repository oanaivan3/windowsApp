using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect_PAW_IvanOanaGeorgiana
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=193.226.34.57)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orclpdb.docker.internal)));User Id=DUMITRUS_43;Password=stud;";

        private void pictureBox1Minimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBox2Close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShowParola_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShowParola, "Arata Parola");
        }

        private void pictureBoxHideParola_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHideParola, "Ascunde Parola");
        }

        private void pictureBoxShowParola_Click(object sender, EventArgs e)
        {
            pictureBoxShowParola.Hide();
            textBoxParola.UseSystemPasswordChar = false;
            pictureBoxHideParola.Show();
        }

        private void pictureBoxHideParola_Click(object sender, EventArgs e)
        {
            pictureBoxHideParola.Hide();
            textBoxParola.UseSystemPasswordChar = true;
            pictureBoxShowParola.Show();
        }

      

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
        private void buttonLogare_Click(object sender, EventArgs e)
            {
                string username = textBoxUsername.Text;
                string password = textBoxParola.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                using (OracleConnection connection = new OracleConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM UTILIZATORIAPLICATIE WHERE Mail = :Username AND Parola = :Password";
                        OracleCommand command = new OracleCommand(query, connection);
                        command.Parameters.Add(new OracleParameter("Username", username));
                        command.Parameters.Add(new OracleParameter("Password", password));
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");


                            FormDashboard dashboardForm = new FormDashboard();
                            dashboardForm.Show();


                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
    }

