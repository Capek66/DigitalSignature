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
            this.btnCreate = new System.Windows.Forms.Button();
            this.succes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(90, 50);
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
            this.succes.Location = new System.Drawing.Point(81, 111);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(160, 13);
            this.succes.TabIndex = 5;
            this.succes.Text = "Simetrični ključ uspješno kreiran!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stvaranje simetričnog ključa";
            // 
            // CreateSymKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateSymKey";
            this.Size = new System.Drawing.Size(317, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Label label3;
    }
}
