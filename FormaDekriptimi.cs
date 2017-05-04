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
using System.Diagnostics;

namespace ProjektiFinal_DEScrack_Siguri
{
    public partial class FormaDekriptimi : Form
    {
     
        public FormaDekriptimi()
        {
            InitializeComponent();
        }
        public static string Encrypt(string message, string password)
        {
            // Encode message and password
            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            // Set encryption settings -- Use password for both key and init. vector
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and encrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read the encrypted message from the memory stream
            byte[] encryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            // Encode the encrypted message as base64 string
            string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

            return encryptedMessage;
        }
        public static string Decrypt(string encryptedMessage, string password)
        {
            // Convert encrypted message and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            // Set encryption settings -- Use password for both key and init. vector
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and decrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read decrypted message from memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            // Encode deencrypted binary data to base64 string
            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);


            return message;
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPsw.Text == "" )
                {
                    MessageBox.Show("Ju lutem shtypeni passwordin per dekriptim (per te gjetur passwordin kliko butonin 'passwordi' ne te djathte) !");
                }
                else if ( txtEnc.Text == "")
                {
                    MessageBox.Show("Ju lutem shtypeni tekstin e enkriptuar (per te gjetur tekstin kliko butonin 'Enc Teskti' ne te djathte) !");
                }
                else
                {
                    txtDec.Text = Decrypt(txtEnc.Text, txtPsw.Text);
                }
            }
            catch (Exception eX)
            {

                MessageBox.Show(eX.Message);
            }
        }
        private void FormaDekriptimi_Load(object sender, EventArgs e)
        {
            FormaKryesore forma1 = new FormaKryesore(); 
        }
        private void btnRuaj(object sender, EventArgs e) //Passwordi button
        {
            try
            {
                //Opens the file which we use to save our enc passwords
                //Process.Start(@"C:\\SavePassword.txt");
                StreamReader sr = File.OpenText("SavePassword.txt");
                string src = sr.ReadLine();
                txtPsw.Text = src;
                sr.Close();

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
        private void btnEncPass_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = File.OpenText(@"SaveEncryptedText.txt");
                string src = sr.ReadLine();
                txtEnc.Text = src;
                sr.Close();
                //Opens the file which we use to save our enc text
                //Process.Start(@"C:\\SaveEncryptedText.txt");
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
