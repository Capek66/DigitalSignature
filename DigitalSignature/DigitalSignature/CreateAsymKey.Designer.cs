namespace DigitalSignature
{
    partial class CreateAsymKey
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
            this.succes = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.SystemColors.Control;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(75, 138);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(136, 13);
            this.error.TabIndex = 13;
            this.error.Text = "Neka polja nisu popunjena!";
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.BackColor = System.Drawing.SystemColors.Control;
            this.succes.ForeColor = System.Drawing.Color.DarkGreen;
            this.succes.Location = new System.Drawing.Point(64, 138);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(165, 13);
            this.succes.TabIndex = 12;
            this.succes.Text = "Asimetrični ključ uspješno kreiran!";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(67, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 31);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Stvori asimetrični ključ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(67, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(67, 50);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(144, 20);
            this.tbSurname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // CreateAsynKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAsynKey";
            this.Size = new System.Drawing.Size(264, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
