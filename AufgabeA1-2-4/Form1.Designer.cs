namespace AufgabeA1_2_4
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
            this.CmdWindowHeightBigger = new System.Windows.Forms.Button();
            this.CmdWindowHeightSmaller = new System.Windows.Forms.Button();
            this.CmdWindowsWidthBigger = new System.Windows.Forms.Button();
            this.CmdWindowWidthSmaller = new System.Windows.Forms.Button();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblDimension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdWindowHeightBigger
            // 
            this.CmdWindowHeightBigger.Location = new System.Drawing.Point(12, 12);
            this.CmdWindowHeightBigger.Name = "CmdWindowHeightBigger";
            this.CmdWindowHeightBigger.Size = new System.Drawing.Size(260, 23);
            this.CmdWindowHeightBigger.TabIndex = 0;
            this.CmdWindowHeightBigger.Text = "Fensterhöhe vergrössern";
            this.CmdWindowHeightBigger.UseVisualStyleBackColor = true;
            this.CmdWindowHeightBigger.Click += new System.EventHandler(this.CmdWindowHeightBigger_Click);
            // 
            // CmdWindowHeightSmaller
            // 
            this.CmdWindowHeightSmaller.Location = new System.Drawing.Point(12, 41);
            this.CmdWindowHeightSmaller.Name = "CmdWindowHeightSmaller";
            this.CmdWindowHeightSmaller.Size = new System.Drawing.Size(260, 23);
            this.CmdWindowHeightSmaller.TabIndex = 1;
            this.CmdWindowHeightSmaller.Text = "Fensterhöhe verkleinern";
            this.CmdWindowHeightSmaller.UseVisualStyleBackColor = true;
            this.CmdWindowHeightSmaller.Click += new System.EventHandler(this.CmdWindowHeightSmaller_Click);
            // 
            // CmdWindowsWidthBigger
            // 
            this.CmdWindowsWidthBigger.Location = new System.Drawing.Point(12, 70);
            this.CmdWindowsWidthBigger.Name = "CmdWindowsWidthBigger";
            this.CmdWindowsWidthBigger.Size = new System.Drawing.Size(260, 23);
            this.CmdWindowsWidthBigger.TabIndex = 2;
            this.CmdWindowsWidthBigger.Text = "Fensterbreite vergrössern";
            this.CmdWindowsWidthBigger.UseVisualStyleBackColor = true;
            this.CmdWindowsWidthBigger.Click += new System.EventHandler(this.CmdWindowsWidthBigger_Click);
            // 
            // CmdWindowWidthSmaller
            // 
            this.CmdWindowWidthSmaller.Location = new System.Drawing.Point(12, 99);
            this.CmdWindowWidthSmaller.Name = "CmdWindowWidthSmaller";
            this.CmdWindowWidthSmaller.Size = new System.Drawing.Size(260, 23);
            this.CmdWindowWidthSmaller.TabIndex = 3;
            this.CmdWindowWidthSmaller.Text = "Fensterbreite verkleinern";
            this.CmdWindowWidthSmaller.UseVisualStyleBackColor = true;
            this.CmdWindowWidthSmaller.Click += new System.EventHandler(this.CmdWindowWidthSmaller_Click);
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(13, 188);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 4;
            this.LblPosition.Text = "Position:";
            // 
            // LblDimension
            // 
            this.LblDimension.AutoSize = true;
            this.LblDimension.Location = new System.Drawing.Point(144, 188);
            this.LblDimension.Name = "LblDimension";
            this.LblDimension.Size = new System.Drawing.Size(59, 13);
            this.LblDimension.TabIndex = 5;
            this.LblDimension.Text = "Dimension:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.LblDimension);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.CmdWindowWidthSmaller);
            this.Controls.Add(this.CmdWindowsWidthBigger);
            this.Controls.Add(this.CmdWindowHeightSmaller);
            this.Controls.Add(this.CmdWindowHeightBigger);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdWindowHeightBigger;
        private System.Windows.Forms.Button CmdWindowHeightSmaller;
        private System.Windows.Forms.Button CmdWindowsWidthBigger;
        private System.Windows.Forms.Button CmdWindowWidthSmaller;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblDimension;
    }
}

