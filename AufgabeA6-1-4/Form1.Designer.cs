
namespace AufgabeA6_1_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadEvenNumber = new System.Windows.Forms.RadioButton();
            this.RadOddNumber = new System.Windows.Forms.RadioButton();
            this.RadAllNumber = new System.Windows.Forms.RadioButton();
            this.TxtStartNumber = new System.Windows.Forms.TextBox();
            this.TxtEndNumber = new System.Windows.Forms.TextBox();
            this.TxtStepsNumber = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdDeleteOutput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startwert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endwert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Schritt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadAllNumber);
            this.groupBox1.Controls.Add(this.RadOddNumber);
            this.groupBox1.Controls.Add(this.RadEvenNumber);
            this.groupBox1.Location = new System.Drawing.Point(31, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitte wählen Sie";
            // 
            // RadEvenNumber
            // 
            this.RadEvenNumber.AutoSize = true;
            this.RadEvenNumber.Location = new System.Drawing.Point(7, 20);
            this.RadEvenNumber.Name = "RadEvenNumber";
            this.RadEvenNumber.Size = new System.Drawing.Size(96, 17);
            this.RadEvenNumber.TabIndex = 0;
            this.RadEvenNumber.TabStop = true;
            this.RadEvenNumber.Text = "Gerade Zahlen";
            this.RadEvenNumber.UseVisualStyleBackColor = true;
            // 
            // RadOddNumber
            // 
            this.RadOddNumber.AutoSize = true;
            this.RadOddNumber.Location = new System.Drawing.Point(124, 20);
            this.RadOddNumber.Name = "RadOddNumber";
            this.RadOddNumber.Size = new System.Drawing.Size(108, 17);
            this.RadOddNumber.TabIndex = 1;
            this.RadOddNumber.TabStop = true;
            this.RadOddNumber.Text = "Ungerade Zahlen";
            this.RadOddNumber.UseVisualStyleBackColor = true;
            // 
            // RadAllNumber
            // 
            this.RadAllNumber.AutoSize = true;
            this.RadAllNumber.Location = new System.Drawing.Point(255, 19);
            this.RadAllNumber.Name = "RadAllNumber";
            this.RadAllNumber.Size = new System.Drawing.Size(78, 17);
            this.RadAllNumber.TabIndex = 2;
            this.RadAllNumber.TabStop = true;
            this.RadAllNumber.Text = "Alle Zahlen";
            this.RadAllNumber.UseVisualStyleBackColor = true;
            // 
            // TxtStartNumber
            // 
            this.TxtStartNumber.Location = new System.Drawing.Point(31, 64);
            this.TxtStartNumber.Name = "TxtStartNumber";
            this.TxtStartNumber.Size = new System.Drawing.Size(133, 20);
            this.TxtStartNumber.TabIndex = 4;
            // 
            // TxtEndNumber
            // 
            this.TxtEndNumber.Location = new System.Drawing.Point(194, 63);
            this.TxtEndNumber.Name = "TxtEndNumber";
            this.TxtEndNumber.Size = new System.Drawing.Size(125, 20);
            this.TxtEndNumber.TabIndex = 5;
            // 
            // TxtStepsNumber
            // 
            this.TxtStepsNumber.Location = new System.Drawing.Point(337, 63);
            this.TxtStepsNumber.Name = "TxtStepsNumber";
            this.TxtStepsNumber.Size = new System.Drawing.Size(116, 20);
            this.TxtStepsNumber.TabIndex = 6;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(28, 215);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(10, 13);
            this.LblOutput.TabIndex = 7;
            this.LblOutput.Text = ".";
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(31, 106);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(114, 23);
            this.CmdStart.TabIndex = 8;
            this.CmdStart.Text = "Ausgabe starten";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdDeleteOutput
            // 
            this.CmdDeleteOutput.Location = new System.Drawing.Point(175, 106);
            this.CmdDeleteOutput.Name = "CmdDeleteOutput";
            this.CmdDeleteOutput.Size = new System.Drawing.Size(116, 23);
            this.CmdDeleteOutput.TabIndex = 9;
            this.CmdDeleteOutput.Text = "Ausgabe löschen";
            this.CmdDeleteOutput.UseVisualStyleBackColor = true;
            this.CmdDeleteOutput.Click += new System.EventHandler(this.CmdDeleteOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.CmdDeleteOutput);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.TxtStepsNumber);
            this.Controls.Add(this.TxtEndNumber);
            this.Controls.Add(this.TxtStartNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadAllNumber;
        private System.Windows.Forms.RadioButton RadOddNumber;
        private System.Windows.Forms.RadioButton RadEvenNumber;
        private System.Windows.Forms.TextBox TxtStartNumber;
        private System.Windows.Forms.TextBox TxtEndNumber;
        private System.Windows.Forms.TextBox TxtStepsNumber;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdDeleteOutput;
    }
}

