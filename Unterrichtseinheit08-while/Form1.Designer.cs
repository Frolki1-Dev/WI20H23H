
namespace Unterrichtseinheit08_while
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
            this.CmdStart = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumRepeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblTitle.Location = new System.Drawing.Point(29, 24);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(465, 31);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Kontrollstrukturen - Die while Schleife";
            // 
            // CmdStart
            // 
            this.CmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmdStart.Location = new System.Drawing.Point(35, 86);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(104, 35);
            this.CmdStart.TabIndex = 1;
            this.CmdStart.Text = "Let\'s go!";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtInput.Location = new System.Drawing.Point(160, 92);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(218, 29);
            this.TxtInput.TabIndex = 2;
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(35, 160);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(459, 268);
            this.TxtOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(29, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anzahl Wiederholungen";
            // 
            // LblNumRepeats
            // 
            this.LblNumRepeats.AutoSize = true;
            this.LblNumRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LblNumRepeats.Location = new System.Drawing.Point(335, 450);
            this.LblNumRepeats.Name = "LblNumRepeats";
            this.LblNumRepeats.Size = new System.Drawing.Size(29, 31);
            this.LblNumRepeats.TabIndex = 5;
            this.LblNumRepeats.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 507);
            this.Controls.Add(this.LblNumRepeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumRepeats;
    }
}

