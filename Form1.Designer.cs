
namespace MyEncryptionForKey
{
    partial class Form1
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
            this.txtEncryptedWordToDecrypt = new System.Windows.Forms.TextBox();
            this.txtDecryptWord = new System.Windows.Forms.TextBox();
            this.lblEncryptedWordToDecrypt = new System.Windows.Forms.Label();
            this.lblDecryptedWord = new System.Windows.Forms.Label();
            this.txtEncryptionPlainWord = new System.Windows.Forms.TextBox();
            this.txtEncryptedWord = new System.Windows.Forms.TextBox();
            this.lblEncryptionWord = new System.Windows.Forms.Label();
            this.lblEncryptedWord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncryptedWordToDecrypt
            // 
            this.txtEncryptedWordToDecrypt.Location = new System.Drawing.Point(22, 29);
            this.txtEncryptedWordToDecrypt.Multiline = true;
            this.txtEncryptedWordToDecrypt.Name = "txtEncryptedWordToDecrypt";
            this.txtEncryptedWordToDecrypt.Size = new System.Drawing.Size(768, 55);
            this.txtEncryptedWordToDecrypt.TabIndex = 2;
            // 
            // txtDecryptWord
            // 
            this.txtDecryptWord.Location = new System.Drawing.Point(22, 132);
            this.txtDecryptWord.Multiline = true;
            this.txtDecryptWord.Name = "txtDecryptWord";
            this.txtDecryptWord.Size = new System.Drawing.Size(768, 68);
            this.txtDecryptWord.TabIndex = 3;
            // 
            // lblEncryptedWordToDecrypt
            // 
            this.lblEncryptedWordToDecrypt.AutoSize = true;
            this.lblEncryptedWordToDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedWordToDecrypt.Location = new System.Drawing.Point(22, 2);
            this.lblEncryptedWordToDecrypt.Name = "lblEncryptedWordToDecrypt";
            this.lblEncryptedWordToDecrypt.Size = new System.Drawing.Size(427, 24);
            this.lblEncryptedWordToDecrypt.TabIndex = 6;
            this.lblEncryptedWordToDecrypt.Text = "Enter Encrypted word that\'s need to Decrypt:";
            // 
            // lblDecryptedWord
            // 
            this.lblDecryptedWord.AutoSize = true;
            this.lblDecryptedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptedWord.Location = new System.Drawing.Point(22, 105);
            this.lblDecryptedWord.Name = "lblDecryptedWord";
            this.lblDecryptedWord.Size = new System.Drawing.Size(167, 24);
            this.lblDecryptedWord.TabIndex = 7;
            this.lblDecryptedWord.Text = "Decrypted Word:";
            // 
            // txtEncryptionPlainWord
            // 
            this.txtEncryptionPlainWord.Location = new System.Drawing.Point(22, 43);
            this.txtEncryptionPlainWord.Multiline = true;
            this.txtEncryptionPlainWord.Name = "txtEncryptionPlainWord";
            this.txtEncryptionPlainWord.Size = new System.Drawing.Size(768, 47);
            this.txtEncryptionPlainWord.TabIndex = 0;
            // 
            // txtEncryptedWord
            // 
            this.txtEncryptedWord.Location = new System.Drawing.Point(26, 145);
            this.txtEncryptedWord.Multiline = true;
            this.txtEncryptedWord.Name = "txtEncryptedWord";
            this.txtEncryptedWord.Size = new System.Drawing.Size(768, 82);
            this.txtEncryptedWord.TabIndex = 1;
            // 
            // lblEncryptionWord
            // 
            this.lblEncryptionWord.AutoSize = true;
            this.lblEncryptionWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptionWord.Location = new System.Drawing.Point(22, 2);
            this.lblEncryptionWord.Name = "lblEncryptionWord";
            this.lblEncryptionWord.Size = new System.Drawing.Size(375, 24);
            this.lblEncryptionWord.TabIndex = 4;
            this.lblEncryptionWord.Text = "Enter plain word that\'s need to encrypt:";
            // 
            // lblEncryptedWord
            // 
            this.lblEncryptedWord.AutoSize = true;
            this.lblEncryptedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedWord.Location = new System.Drawing.Point(26, 118);
            this.lblEncryptedWord.Name = "lblEncryptedWord";
            this.lblEncryptedWord.Size = new System.Drawing.Size(161, 24);
            this.lblEncryptedWord.TabIndex = 5;
            this.lblEncryptedWord.Text = "Encrypted Word";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnEncrypt);
            this.panel1.Controls.Add(this.lblEncryptedWord);
            this.panel1.Controls.Add(this.lblEncryptionWord);
            this.panel1.Controls.Add(this.txtEncryptedWord);
            this.panel1.Controls.Add(this.txtEncryptionPlainWord);
            this.panel1.Location = new System.Drawing.Point(26, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 254);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.lblDecryptedWord);
            this.panel2.Controls.Add(this.lblEncryptedWordToDecrypt);
            this.panel2.Controls.Add(this.txtDecryptWord);
            this.panel2.Controls.Add(this.txtEncryptedWordToDecrypt);
            this.panel2.Location = new System.Drawing.Point(26, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 244);
            this.panel2.TabIndex = 9;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DarkRed;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEncrypt.Location = new System.Drawing.Point(301, 96);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(107, 39);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecrypt.Location = new System.Drawing.Point(290, 87);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 39);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncryptedWordToDecrypt;
        private System.Windows.Forms.TextBox txtDecryptWord;
        private System.Windows.Forms.Label lblEncryptedWordToDecrypt;
        private System.Windows.Forms.Label lblDecryptedWord;
        private System.Windows.Forms.TextBox txtEncryptionPlainWord;
        private System.Windows.Forms.TextBox txtEncryptedWord;
        private System.Windows.Forms.Label lblEncryptionWord;
        private System.Windows.Forms.Label lblEncryptedWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

