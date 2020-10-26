namespace AufgabeA1_2_2
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
            this.CmdOnePoint = new System.Windows.Forms.Button();
            this.CmdTwoPoints = new System.Windows.Forms.Button();
            this.CmdThreePoints = new System.Windows.Forms.Button();
            this.LblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdOnePoint
            // 
            this.CmdOnePoint.Location = new System.Drawing.Point(13, 13);
            this.CmdOnePoint.Name = "CmdOnePoint";
            this.CmdOnePoint.Size = new System.Drawing.Size(75, 23);
            this.CmdOnePoint.TabIndex = 0;
            this.CmdOnePoint.Text = "1ner";
            this.CmdOnePoint.UseVisualStyleBackColor = true;
            this.CmdOnePoint.Click += new System.EventHandler(this.CmdOnePoint_Click);
            // 
            // CmdTwoPoints
            // 
            this.CmdTwoPoints.Location = new System.Drawing.Point(95, 12);
            this.CmdTwoPoints.Name = "CmdTwoPoints";
            this.CmdTwoPoints.Size = new System.Drawing.Size(75, 23);
            this.CmdTwoPoints.TabIndex = 1;
            this.CmdTwoPoints.Text = "2er";
            this.CmdTwoPoints.UseVisualStyleBackColor = true;
            this.CmdTwoPoints.Click += new System.EventHandler(this.CmdTwoPoints_Click);
            // 
            // CmdThreePoints
            // 
            this.CmdThreePoints.Location = new System.Drawing.Point(177, 12);
            this.CmdThreePoints.Name = "CmdThreePoints";
            this.CmdThreePoints.Size = new System.Drawing.Size(75, 23);
            this.CmdThreePoints.TabIndex = 2;
            this.CmdThreePoints.Text = "3er";
            this.CmdThreePoints.UseVisualStyleBackColor = true;
            this.CmdThreePoints.Click += new System.EventHandler(this.CmdThreePoints_Click);
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Location = new System.Drawing.Point(13, 43);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(0, 13);
            this.LblPoints.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 139);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.CmdThreePoints);
            this.Controls.Add(this.CmdTwoPoints);
            this.Controls.Add(this.CmdOnePoint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOnePoint;
        private System.Windows.Forms.Button CmdTwoPoints;
        private System.Windows.Forms.Button CmdThreePoints;
        private System.Windows.Forms.Label LblPoints;
    }
}

