using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proiect_Radu_Sebastian
{
    public partial class Form2 : Form
    {
        private Sondaje sondaje = new Sondaje();
        List<Sondaje> listaSondaje = new List<Sondaje>();
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public Form2()
        {
            InitializeComponent();
            Sondaje sondaje= new Sondaje();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void AdaugareParticipant_Click(object sender, EventArgs e)
        {
            
            int salariu2023 = Convert.ToInt32(tbSalariu2023.Text);
            int mancare = Convert.ToInt32(tbMancare.Text);
            int chirie = Convert.ToInt32(tbChirie.Text);
            int transport = Convert.ToInt32(tbTransport.Text);
            int rate = Convert.ToInt32(tbRate.Text);

            Sondaje s = new Sondaje(salariu2023, mancare, chirie, transport, rate);
            s.Economii();
            MessageBox.Show("Participant Adaugat");
            listaSondaje.Add(s);

        }

        private void AfisatiRezultate_Click(object sender, EventArgs e)
        {
            float SalariuRamas;
            SalariuRamas = sondaje.Economii();

            string mesajAfisare = "";
            foreach (Sondaje s in listaSondaje)
            {
                mesajAfisare += s.ToString() + SalariuRamas;
            }
            if (radioButton1.Checked) {
                richTextBox1.Text = mesajAfisare + "RON" + Environment.NewLine;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    richTextBox1.Text = mesajAfisare + "EUR" + Environment.NewLine;
                }
                else { richTextBox1.Text = mesajAfisare + "USD" + Environment.NewLine; }
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlCommand cmd;
        private void LV_Click(object sender, EventArgs e)
        {
            int salariu2023 = Convert.ToInt32(tbSalariu2023.Text);
            int mancare = Convert.ToInt32(tbMancare.Text);
            int chirie = Convert.ToInt32(tbChirie.Text);
            int transport = Convert.ToInt32(tbTransport.Text);
            int rate = Convert.ToInt32(tbRate.Text);

            Sondaje s = new Sondaje(salariu2023, mancare, chirie, transport, rate);
            int SalariuRamas = s.Economii() * 10;
            
            //conectare la baza de date si salvare valori;
            
            SqlConnection con = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;DataBase=DetaliiUtilizator;Trusted_Connection=True;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            con.Open();
            
            cmd = new SqlCommand("INSERT INTO DateUtilizatori(Nume, Prenume, Email, Economii) VALUES (@Nume, @Prenume, @Email, @SalariuRamas)", con);
            cmd.Parameters.AddWithValue("@Nume",Nume);
            cmd.Parameters.AddWithValue("@Prenume", Prenume);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SalariuRamas", SalariuRamas);
            
            cmd.ExecuteNonQuery();
            con.Close();

            Form3 form3 = new Form3();
            form3.ShowDialog();
           
        }
    }
}
