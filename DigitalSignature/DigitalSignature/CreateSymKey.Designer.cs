namespace DigitalSignature
{
    partial class CreateSymKey
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.succes = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(75, 51);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(144, 20);
            this.tbSurname.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 20);
            this.tbName.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(75, 87);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Stvori simetrični ključ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.BackColor = System.Drawing.SystemColors.Control;
            this.succes.ForeColor = System.Drawing.Color.DarkGreen;
            this.succes.Location = new System.Drawing.Point(72, 139);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(160, 13);
            this.succes.TabIndex = 5;
            this.succes.Text = "Simetrični ključ uspješno kreiran!";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.SystemColors.Control;
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(83, 139);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(136, 13);
            this.error.TabIndex = 6;
            this.error.Text = "Neka polja nisu popunjena!";
            // 
            // CreateSimKey
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
            this.Name = "CreateSimKey";
            this.Size = new System.Drawing.Size(268, 195);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Label error;
    }
}
