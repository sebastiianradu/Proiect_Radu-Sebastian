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
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Proiect_Radu_Sebastian
{
    public partial class Form1 : Form
    {
        Inscriere inscriere;
        bool ok = false;
        bool ok1 = false;
        bool ok2 = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        public Form1(Inscriere inscriere)
        {   
            InitializeComponent();
            tbNume.Text = inscriere.Nume.ToString();
            tbPrenume.Text = inscriere.Prenume.ToString();
            tbEmail.Text = inscriere.Email.ToString();
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {
            string nume = tbNume.Text;

            if (string.IsNullOrEmpty(nume))
            {
                ok = false;
            }
            ok = true;
        }

        private void tbPrenume_TextChanged(object sender, EventArgs e)
        {
            string prenume = tbPrenume.Text;

            if (string.IsNullOrEmpty(prenume))
            {
                ok1 = false;
            }
            else ok1 = true;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            string email = tbEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                ok2 = false;
            }
            else ok2 = true;
        }

        //verificare email daca e corect
        public bool IsValid()
        {
            String email = tbEmail.Text;
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void IncepetiFromularul_Click(object sender, EventArgs e)
        {
            //conditie ca toate campurile sa fie completate;
            if(ok == false || ok1 == false || ok2 == false)
            {
                MessageBox.Show("Toate campurile trebuie completate!", "Eroare");
                return;
            }
            //conditie sa apara ewroare daca formatul email-ului nu e corect;
             else
                if(IsValid() == false)
            {
                MessageBox.Show("Adresa de email este invalida. Asigura-te că introduci o adresa de email valida.", "Eroare");
                return;
            }

            string Nume = tbNume.Text;
            string Prenume = tbPrenume.Text;
            string Email = tbEmail.Text;
            Form2 form2 = new Form2();
            form2.Nume = Nume;
            form2.Prenume = Prenume;
            form2.Email = Email;
            form2.ShowDialog();

        }


    }
}
