namespace DigitalSignature
{
    partial class DigSign
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
            this.btnSign = new System.Windows.Forms.Button();
            this.succes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(173, 166);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(153, 13);
            this.error.TabIndex = 38;
            this.error.Text = "Ključ ili datoteka nisu odabrani!";
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(354, 116);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(95, 32);
            this.btnSign.TabIndex = 36;
            this.btnSign.Text = "Potpiši";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.ForeColor = System.Drawing.Color.Green;
            this.succes.Location = new System.Drawing.Point(150, 166);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(201, 13);
            this.succes.TabIndex = 34;
            this.succes.Text = "Datoteka je uspješno digitalno potpisana!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Odaberite datoteku za potpisivanje:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(374, 77);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 31;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(223, 77);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(145, 20);
            this.tbFile.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Odaberite datoteku s Vašim privatnim ključem:";
            // 
            // btnChooseKey
            // 
            this.btnChooseKey.Location = new System.Drawing.Point(374, 42);
            this.btnChooseKey.Name = "btnChooseKey";
            this.btnChooseKey.Size = new System.Drawing.Size(75, 20);
            this.btnChooseKey.TabIndex = 28;
            this.btnChooseKey.Text = "Choose File";
            this.btnChooseKey.UseVisualStyleBackColor = true;
            this.btnChooseKey.Click += new System.EventHandler(this.btnChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(223, 42);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(145, 20);
            this.tbKey.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Digitalno potpisivanje datoteke";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 192);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(418, 13);
            this.info.TabIndex = 39;
            this.info.Text = "Napomena: Datoteka sa potpisom nalazi se u istom direktoriju kao i odabrana datot" +
    "eka!";
            // 
            // DigSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.info);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label1);
            this.Name = "DigSign";
            this.Size = new System.Drawing.Size(469, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
    }
}
