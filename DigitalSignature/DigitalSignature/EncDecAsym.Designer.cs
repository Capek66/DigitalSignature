namespace DigitalSignature
{
    partial class EncDecAsym
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.error = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.succesDec = new System.Windows.Forms.Label();
            this.succesEnc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(168, 179);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(153, 13);
            this.error.TabIndex = 25;
            this.error.Text = "Ključ ili datoteka nisu odabrani!";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(260, 129);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(95, 32);
            this.btnDecrypt.TabIndex = 24;
            this.btnDecrypt.Text = "Dekriptiraj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(133, 129);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(95, 32);
            this.btnEncrypt.TabIndex = 23;
            this.btnEncrypt.Text = "Kriptiraj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // succesDec
            // 
            this.succesDec.AutoSize = true;
            this.succesDec.ForeColor = System.Drawing.Color.Green;
            this.succesDec.Location = new System.Drawing.Point(26, 179);
            this.succesDec.Name = "succesDec";
            this.succesDec.Size = new System.Drawing.Size(420, 13);
            this.succesDec.TabIndex = 22;
            this.succesDec.Text = "Datoteka je uspješno dekriptirana i nalazi se u istom direktoriju kao i odabrana " +
    "datoteka!";
            // 
            // succesEnc
            // 
            this.succesEnc.AutoSize = true;
            this.succesEnc.ForeColor = System.Drawing.Color.Green;
            this.succesEnc.Location = new System.Drawing.Point(26, 179);
            this.succesEnc.Name = "succesEnc";
            this.succesEnc.Size = new System.Drawing.Size(408, 13);
            this.succesEnc.TabIndex = 21;
            this.succesEnc.Text = "Datoteka je uspješno kriptirana i nalazi se u istom direktoriju kao i odabrana da" +
    "toteka!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Napomena: Za kriptiranje koristite javni ključ, a za dekriptiranje privatni ključ" +
    "!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Odaberite datoteku za kriptiranje/dekriptiranje:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(385, 92);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 18;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(234, 92);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(145, 20);
            this.tbFile.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Odaberite datoteku s ključem:";
            // 
            // btnChooseKey
            // 
            this.btnChooseKey.Location = new System.Drawing.Point(310, 42);
            this.btnChooseKey.Name = "btnChooseKey";
            this.btnChooseKey.Size = new System.Drawing.Size(75, 20);
            this.btnChooseKey.TabIndex = 15;
            this.btnChooseKey.Text = "Choose File";
            this.btnChooseKey.UseVisualStyleBackColor = true;
            this.btnChooseKey.Click += new System.EventHandler(this.btnChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(159, 42);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(145, 20);
            this.tbKey.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kriptiranje i dekriptiranje asimetričnim algoritmom";
            // 
            // EncDecAsym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.succesDec);
            this.Controls.Add(this.succesEnc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label1);
            this.Name = "EncDecAsym";
            this.Size = new System.Drawing.Size(499, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label succesDec;
        private System.Windows.Forms.Label succesEnc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
    }
}
