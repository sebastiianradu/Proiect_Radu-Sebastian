using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proiect_Radu_Sebastian
{
    public partial class Form3 : Form
    {

        SqlDataAdapter adapter;
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;DataBase=DetaliiUtilizator;Trusted_Connection=True;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void AfisareSondaj_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM DateUtilizatori", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //salvare ca csv

        private void SaveAsCSV(string filePath, DataGridView dataGridView)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sb.Append(column.HeaderText);
                sb.Append(",");
            }
            sb.AppendLine();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(",");
                }
                sb.AppendLine();
            }
            //scrierea fisierului CSV
            File.WriteAllText(filePath, sb.ToString());
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //salvarea fisierului CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save as CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsCSV(filePath, dataGridView1);
                MessageBox.Show("Fisierul CSV a fost salvat cu succes");
            }
        }

        private void DELETEdb_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;DataBase=DetaliiUtilizator;Trusted_Connection=True;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM DateUtilizatori", connection);

                // comanda de stergere
                command.ExecuteNonQuery();

                MessageBox.Show("Stergerea a fost efectuata cu succes!");

                connection.Close();
            }

            Console.ReadLine();
        }
    }
}
