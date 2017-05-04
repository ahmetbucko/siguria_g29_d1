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

namespace ProjektiFinal_DEScrack_Siguri
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        CrackForma frmCrac = new CrackForma();
        FormaKryesore frmKry = new FormaKryesore();
        FormaDekriptimi frmDec = new FormaDekriptimi();

        private void btnEkripto_Click(object sender, EventArgs e)
        {
            frmKry.Show();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            //frmCrac.Show();
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            frmDec.Show();
        }

        private void dESECBEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaKryesore enc = new FormaKryesore();
            //enc.ShowDialog();
            enc.Show();
        }

        private void dESECBDecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaDekriptimi dec = new FormaDekriptimi();
            dec.ShowDialog();
        }

        private void dESDictionaryAttackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrackForma frmC = new CrackForma();
            
            frmC.ShowDialog();
            //this.Hide();
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prgInfo info = new prgInfo();
            info.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactUs cnt = new contactUs();
            cnt.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}


