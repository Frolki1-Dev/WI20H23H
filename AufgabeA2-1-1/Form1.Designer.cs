namespace AufgabeA2_1_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFirstname = new System.Windows.Forms.Label();
            this.LblLastname = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.CmdOutput = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFirstname
            // 
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(12, 38);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(49, 13);
            this.LblFirstname.TabIndex = 0;
            this.LblFirstname.Text = "Vorname";
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(12, 68);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(59, 13);
            this.LblLastname.TabIndex = 1;
            this.LblLastname.Text = "Nachname";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(99, 35);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(149, 20);
            this.TxtFirstname.TabIndex = 2;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(99, 65);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(149, 20);
            this.TxtLastname.TabIndex = 3;
            // 
            // CmdOutput
            // 
            this.CmdOutput.Location = new System.Drawing.Point(99, 108);
            this.CmdOutput.Name = "CmdOutput";
            this.CmdOutput.Size = new System.Drawing.Size(75, 23);
            this.CmdOutput.TabIndex = 4;
            this.CmdOutput.Text = "Ausgeben";
            this.CmdOutput.UseVisualStyleBackColor = true;
            this.CmdOutput.Click += new System.EventHandler(this.CmdOutput_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(180, 108);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 5;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(99, 164);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(16, 13);
            this.LblOutput.TabIndex = 6;
            this.LblOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 238);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdOutput);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.LblLastname);
            this.Controls.Add(this.LblFirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Button CmdOutput;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Label LblOutput;
    }
}

