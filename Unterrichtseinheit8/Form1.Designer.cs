
namespace Unterrichtseinheit8
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.cmd_start = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.LblRepeat = new System.Windows.Forms.Label();
            this.LblNumRep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(512, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Kontrollstrukturen - Die for Schleife";
            // 
            // cmd_start
            // 
            this.cmd_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_start.Location = new System.Drawing.Point(12, 97);
            this.cmd_start.Name = "cmd_start";
            this.cmd_start.Size = new System.Drawing.Size(106, 35);
            this.cmd_start.TabIndex = 1;
            this.cmd_start.Text = "Start";
            this.cmd_start.UseVisualStyleBackColor = true;
            this.cmd_start.Click += new System.EventHandler(this.cmd_start_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(12, 151);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(776, 208);
            this.TxtOutput.TabIndex = 2;
            // 
            // LblRepeat
            // 
            this.LblRepeat.AutoSize = true;
            this.LblRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepeat.Location = new System.Drawing.Point(19, 387);
            this.LblRepeat.Name = "LblRepeat";
            this.LblRepeat.Size = new System.Drawing.Size(300, 31);
            this.LblRepeat.TabIndex = 3;
            this.LblRepeat.Text = "Anzahl Wiederholungen";
            // 
            // LblNumRep
            // 
            this.LblNumRep.AutoSize = true;
            this.LblNumRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LblNumRep.Location = new System.Drawing.Point(325, 387);
            this.LblNumRep.Name = "LblNumRep";
            this.LblNumRep.Size = new System.Drawing.Size(38, 31);
            this.LblNumRep.TabIndex = 4;
            this.LblNumRep.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblNumRep);
            this.Controls.Add(this.LblRepeat);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.cmd_start);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button cmd_start;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Label LblRepeat;
        private System.Windows.Forms.Label LblNumRep;
    }
}

