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
    public partial class FormaKryesore : Form
    {
        public FormaKryesore()
        {
            InitializeComponent();
        }
        public static string Encrypt(string message, string password)
        {
            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);//Symetric encryptor object with current key and IV
            CryptoStreamMode mode = CryptoStreamMode.Write;

            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock(); //Flush method can be called once inside each loop, for every loop we need to create new stream 
                                            // if we want to call Flush  method again, in another case will be a bug !!

            byte[] encryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes); //Converts the value of encryptedMessage of 8-bit unsigned 
                                                                                     //integers to its equivalent string representation that is encoded with base-64 digits.
            return encryptedMessage;
        }
        public static string Decrypt(string encryptedMessage, string password)
        {

            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] decryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);

            return message;
        }
        private void btnEnkriptimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnecrypted.Text == "")
                {
                    MessageBox.Show("Ju lutem shtypni tekstin qe doni ta enkriptoni");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Ju lutem shtypni passwordin per enkriptim");
                }
                else
                {
                    string unencrypted = txtUnecrypted.Text;
                    string password = txtPassword.Text;
                    txtEncrypted.Text = Encrypt(unencrypted, password);
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(txtPassword.Text));
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
            CrackForma frmC = new CrackForma();
            frmC.formaKryesore = this;
        }
        private void btnSaveEncryptenText_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter SaveEncryptedText = new StreamWriter("SaveEncryptedText.txt");
                SaveEncryptedText.Write(txtEncrypted.Text);
                MessageBox.Show("Encrypted text has been saved !");
                SaveEncryptedText.Close();     
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CrackForma frmC = new CrackForma();
            frmC.formaKryesore = this;
            frmC.Show();
            this.Hide();
        }
    }
}



