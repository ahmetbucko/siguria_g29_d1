namespace ProjektiFinal_DEScrack_Siguri
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESECBEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESECBDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESDictionaryAttackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESECBEncryptionToolStripMenuItem,
            this.dESECBDecryptionToolStripMenuItem,
            this.dESDictionaryAttackToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dESECBEncryptionToolStripMenuItem
            // 
            this.dESECBEncryptionToolStripMenuItem.Name = "dESECBEncryptionToolStripMenuItem";
            this.dESECBEncryptionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dESECBEncryptionToolStripMenuItem.Text = "DES (ECB) Encryption";
            this.dESECBEncryptionToolStripMenuItem.Click += new System.EventHandler(this.dESECBEncryptionToolStripMenuItem_Click);
            // 
            // dESECBDecryptionToolStripMenuItem
            // 
            this.dESECBDecryptionToolStripMenuItem.Name = "dESECBDecryptionToolStripMenuItem";
            this.dESECBDecryptionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dESECBDecryptionToolStripMenuItem.Text = "DES (ECB) Decryption";
            this.dESECBDecryptionToolStripMenuItem.Click += new System.EventHandler(this.dESECBDecryptionToolStripMenuItem_Click);
            // 
            // dESDictionaryAttackToolStripMenuItem
            // 
            this.dESDictionaryAttackToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.dESDictionaryAttackToolStripMenuItem.Name = "dESDictionaryAttackToolStripMenuItem";
            this.dESDictionaryAttackToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dESDictionaryAttackToolStripMenuItem.Text = "DES Dictionary Attack";
            this.dESDictionaryAttackToolStripMenuItem.Click += new System.EventHandler(this.dESDictionaryAttackToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programInfoToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.programInfoToolStripMenuItem.Text = "Program Info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjektiFinal_DEScrack_Siguri.Properties.Resources.source;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(908, 584);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES Application";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESECBEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESECBDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESDictionaryAttackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
    }
}