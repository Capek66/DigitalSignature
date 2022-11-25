namespace DigitalSignature
{
    partial class EncDecSym
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnChooseKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.succesEnc = new System.Windows.Forms.Label();
            this.succesDec = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriptiranje i dekriptiranje simetričnim algoritmom";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(159, 42);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(145, 20);
            this.tbKey.TabIndex = 1;
            // 
            // btnChooseKey
            // 
            this.btnChooseKey.Location = new System.Drawing.Point(310, 42);
            this.btnChooseKey.Name = "btnChooseKey";
            this.btnChooseKey.Size = new System.Drawing.Size(75, 20);
            this.btnChooseKey.TabIndex = 2;
            this.btnChooseKey.Text = "Choose File";
            this.btnChooseKey.UseVisualStyleBackColor = true;
            this.btnChooseKey.Click += new System.EventHandler(this.btnChooseKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite datoteku s ključem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odaberite datoteku za kriptiranje/dekriptiranje:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(385, 92);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 5;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(234, 92);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(145, 20);
            this.tbFile.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Napomena: Za kriptiranje i dekriptiranje koristite ključ za simetrični algoritam!" +
    "";
            // 
            // succesEnc
            // 
            this.succesEnc.AutoSize = true;
            this.succesEnc.ForeColor = System.Drawing.Color.Green;
            this.succesEnc.Location = new System.Drawing.Point(26, 179);
            this.succesEnc.Name = "succesEnc";
            this.succesEnc.Size = new System.Drawing.Size(408, 13);
            this.succesEnc.TabIndex = 8;
            this.succesEnc.Text = "Datoteka je uspješno kriptirana i nalazi se u istom direktoriju kao i odabrana da" +
    "toteka!";
            // 
            // succesDec
            // 
            this.succesDec.AutoSize = true;
            this.succesDec.ForeColor = System.Drawing.Color.Green;
            this.succesDec.Location = new System.Drawing.Point(26, 179);
            this.succesDec.Name = "succesDec";
            this.succesDec.Size = new System.Drawing.Size(420, 13);
            this.succesDec.TabIndex = 9;
            this.succesDec.Text = "Datoteka je uspješno dekriptirana i nalazi se u istom direktoriju kao i odabrana " +
    "datoteka!";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(133, 129);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(95, 32);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Kriptiraj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(260, 129);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(95, 32);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Dekriptiraj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(168, 179);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(153, 13);
            this.error.TabIndex = 12;
            this.error.Text = "Ključ ili datoteka nisu odabrani!";
            // 
            // EncDecSym
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
            this.Name = "EncDecSym";
            this.Size = new System.Drawing.Size(482, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnChooseKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label succesEnc;
        private System.Windows.Forms.Label succesDec;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label error;
    }
}
