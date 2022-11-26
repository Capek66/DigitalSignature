namespace DigitalSignature
{
    partial class HashCalc
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
            this.btnGetHash = new System.Windows.Forms.Button();
            this.succes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetHash
            // 
            this.btnGetHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetHash.Location = new System.Drawing.Point(143, 81);
            this.btnGetHash.Name = "btnGetHash";
            this.btnGetHash.Size = new System.Drawing.Size(129, 32);
            this.btnGetHash.TabIndex = 36;
            this.btnGetHash.Text = "Izračunaj sažetak";
            this.btnGetHash.UseVisualStyleBackColor = true;
            this.btnGetHash.Click += new System.EventHandler(this.btnGetHash_Click);
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.ForeColor = System.Drawing.Color.Green;
            this.succes.Location = new System.Drawing.Point(155, 127);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(106, 13);
            this.succes.TabIndex = 34;
            this.succes.Text = "Sažetak je izračunat!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(5, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Napomena: Sažetak se također nalazi u novokreiranoj datoteci u istom direktoriju " +
    "kao i odabrana datoteka!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sažetak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Odaberite datoteku:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(310, 42);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 28;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbDat
            // 
            this.tbDat.Location = new System.Drawing.Point(112, 42);
            this.tbDat.Name = "tbDat";
            this.tbDat.Size = new System.Drawing.Size(192, 20);
            this.tbDat.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Izračunavanje sažetka datoteke";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(151, 127);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(121, 13);
            this.error.TabIndex = 37;
            this.error.Text = "Datoteka nije odabrana!";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(60, 153);
            this.tbHash.Name = "tbHash";
            this.tbHash.ReadOnly = true;
            this.tbHash.Size = new System.Drawing.Size(456, 20);
            this.tbHash.TabIndex = 38;
            // 
            // HashCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnGetHash);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbDat);
            this.Controls.Add(this.label1);
            this.Name = "HashCalc";
            this.Size = new System.Drawing.Size(532, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetHash;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox tbHash;
    }
}
