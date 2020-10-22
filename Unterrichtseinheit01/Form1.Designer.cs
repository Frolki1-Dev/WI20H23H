namespace Unterrichtseinheit01
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
            this.CmdMyButton = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMyButton
            // 
            this.CmdMyButton.BackColor = System.Drawing.Color.Yellow;
            this.CmdMyButton.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMyButton.ForeColor = System.Drawing.Color.Gray;
            this.CmdMyButton.Location = new System.Drawing.Point(504, 391);
            this.CmdMyButton.Name = "CmdMyButton";
            this.CmdMyButton.Size = new System.Drawing.Size(266, 50);
            this.CmdMyButton.TabIndex = 0;
            this.CmdMyButton.Text = "My badass button";
            this.CmdMyButton.UseVisualStyleBackColor = false;
            this.CmdMyButton.Click += new System.EventHandler(this.CmdMyButton_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblOutput.Location = new System.Drawing.Point(12, 9);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(52, 51);
            this.LblOutput.TabIndex = 1;
            this.LblOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CmdMyButton);
            this.Name = "Form1";
            this.Text = "Unterrichtseinheit 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMyButton;
        private System.Windows.Forms.Label LblOutput;
    }
}

