# siguria_g29_d1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ProjektiFinal_DEScrack_Siguri
{
    public partial class CrackForma : Form
    {
       public FormaKryesore formaKryesore;
       private FormaDekriptimi Decriptionform;


        public CrackForma()
        {
            InitializeComponent();
        }
        
        private void CrackForma_Load(object sender, EventArgs e)
        {
            //formaKryesore = new FormaKryesore();
            //formaKryesore.Show(); 
        }
        private void btnKerko_Click(object sender, EventArgs e)
        {
            try
            {
                txtRezultati.Text = formaKryesore.txtPassword.Text;
                string pass = ((FormaKryesore)formaKryesore).txtPassword.Text;

                //String toSearch = txtRezultati.Text;
                string toSearch = pass;
                String pathSource = @"PasswordDictionary.txt";

                using (StreamReader sr = new StreamReader(pathSource))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == toSearch)
                        {
                           // Console.ForegroundColor = ConsoleColor.Red;
                            txtRezultati.ForeColor = Color.Green;
                            //txtRezultati.Text = "Password is:  " + line.ToString();
                            txtRezultati.Text = line.ToString();
                            Decriptionform = new FormaDekriptimi();
                            //formaKryesore.Hide();
                            //Decriptionform.Show();
                            break;

                        }
                        else
                        {
                            txtRezultati.ForeColor = Color.Red;
                            txtRezultati.Text = "No match found !";
                            Decriptionform = new FormaDekriptimi();
                            Decriptionform.Close();
                        }
                    }
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
     

        private void btnFajlli_Click(object sender, EventArgs e) //The button for readin whole file lines
        {
            try
            {
                string value1 = File.ReadAllText("PasswordDictionary.txt");
                txtFajlli.Text = value1;
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
        private void btnMbylle_Click(object sender, EventArgs e)
        {
           this.Close();          
        }
        private void button1_Click(object sender, EventArgs e) //Ruaj button
        {
            try
            {
                StreamWriter SavePassword = new StreamWriter("SavePassword.txt");
                MessageBox.Show("Passwordi eshte ruajtur !");
                SavePassword.Write(txtRezultati.Text);
                SavePassword.Close();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            Decriptionform.Show();
        }
    }
}
