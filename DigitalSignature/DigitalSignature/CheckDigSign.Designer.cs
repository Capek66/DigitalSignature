namespace DigitalSignature
{
    partial class CheckDigSign
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.valid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseSign = new System.Windows.Forms.Button();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.notValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(164, 198);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(187, 13);
            this.error.TabIndex = 49;
            this.error.Text = "Ključ, datoteka ili potpis nisu odabrani!";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(323, 151);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(95, 32);
            this.btnCheck.TabIndex = 48;
            this.btnCheck.Text = "Provjeri";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // valid
            // 
            this.valid.AutoSize = true;
            this.valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid.ForeColor = System.Drawing.Color.Green;
            this.valid.Location = new System.Drawing.Point(98, 221);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(230, 24);
            this.valid.TabIndex = 47;
            this.valid.Text = "Digitalni potpis je ispravan!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Odaberite datoteku za provjeru:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(343, 77);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 45;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(192, 78);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(145, 20);
            this.tbFile.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Odaberite datoteku s javnim ključem:";
            // 
            // btnChooseKey
            // 
            this.btnChooseKey.Location = new System.Drawing.Point(343, 41);
            this.btnChooseKey.Name = "btnChooseKey";
            this.btnChooseKey.Size = new System.Drawing.Size(75, 20);
            this.btnChooseKey.TabIndex = 42;
            this.btnChooseKey.Text = "Choose File";
            this.btnChooseKey.UseVisualStyleBackColor = true;
            this.btnChooseKey.Click += new System.EventHandler(this.btnChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(192, 42);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(145, 20);
            this.tbKey.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Provjera digitalnog potpisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Odaberite digitalni potpis datoteke:";
            // 
            // btnChooseSign
            // 
            this.btnChooseSign.Location = new System.Drawing.Point(343, 112);
            this.btnChooseSign.Name = "btnChooseSign";
            this.btnChooseSign.Size = new System.Drawing.Size(75, 20);
            this.btnChooseSign.TabIndex = 52;
            this.btnChooseSign.Text = "Choose File";
            this.btnChooseSign.UseVisualStyleBackColor = true;
            this.btnChooseSign.Click += new System.EventHandler(this.btnChooseSign_Click);
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(192, 112);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(145, 20);
            this.tbSignature.TabIndex = 51;
            // 
            // notValid
            // 
            this.notValid.AutoSize = true;
            this.notValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notValid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notValid.Location = new System.Drawing.Point(90, 221);
            this.notValid.Name = "notValid";
            this.notValid.Size = new System.Drawing.Size(261, 24);
            this.notValid.TabIndex = 54;
            this.notValid.Text = "Digitalni postpis je neispravan!";
            // 
            // CheckDigSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notValid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChooseSign);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label1);
            this.Name = "CheckDigSign";
            this.Size = new System.Drawing.Size(494, 267);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label valid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseSign;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label notValid;
    }
}
