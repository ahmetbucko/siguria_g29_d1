namespace ProjektiFinal_DEScrack_Siguri
{
    partial class FormaDekriptimi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEncPass = new System.Windows.Forms.Button();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password for Decryption";
            // 
            // txtPsw
            // 
            this.txtPsw.BackColor = System.Drawing.Color.White;
            this.txtPsw.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPsw.ForeColor = System.Drawing.Color.Red;
            this.txtPsw.Location = new System.Drawing.Point(99, 133);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPsw.Multiline = true;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(706, 48);
            this.txtPsw.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encrypted Text";
            // 
            // txtEnc
            // 
            this.txtEnc.BackColor = System.Drawing.Color.White;
            this.txtEnc.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtEnc.ForeColor = System.Drawing.Color.Green;
            this.txtEnc.Location = new System.Drawing.Point(99, 216);
            this.txtEnc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnc.Multiline = true;
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(706, 48);
            this.txtEnc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decrypted Text";
            // 
            // txtDec
            // 
            this.txtDec.BackColor = System.Drawing.Color.White;
            this.txtDec.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtDec.Location = new System.Drawing.Point(99, 296);
            this.txtDec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDec.Multiline = true;
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(706, 48);
            this.txtDec.TabIndex = 10;
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackColor = System.Drawing.Color.White;
            this.btnDekripto.FlatAppearance.BorderSize = 0;
            this.btnDekripto.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(811, 296);
            this.btnDekripto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(96, 48);
            this.btnDekripto.TabIndex = 11;
            this.btnDekripto.Text = "Decrypt";
            this.btnDekripto.UseVisualStyleBackColor = false;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Verdana", 8F);
            this.button1.Location = new System.Drawing.Point(811, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRuaj);
            // 
            // btnEncPass
            // 
            this.btnEncPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncPass.FlatAppearance.BorderSize = 0;
            this.btnEncPass.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnEncPass.Location = new System.Drawing.Point(811, 216);
            this.btnEncPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncPass.Name = "btnEncPass";
            this.btnEncPass.Size = new System.Drawing.Size(96, 49);
            this.btnEncPass.TabIndex = 13;
            this.btnEncPass.Text = "Enc Text";
            this.btnEncPass.UseVisualStyleBackColor = false;
            this.btnEncPass.Click += new System.EventHandler(this.btnEncPass_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Black;
            this.lblMinimize.Location = new System.Drawing.Point(912, 10);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(30, 33);
            this.lblMinimize.TabIndex = 23;
            this.lblMinimize.Text = "_";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(952, 9);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 34);
            this.lblClose.TabIndex = 22;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // FormaDekriptimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnEncPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaDekriptimi";
            this.Text = "Dekriptimi";
            this.Load += new System.EventHandler(this.FormaDekriptimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEncPass;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}