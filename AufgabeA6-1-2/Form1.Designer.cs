
namespace AufgabeA6_1_2
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
            this.CmdLoopA = new System.Windows.Forms.Button();
            this.CmdLoop2 = new System.Windows.Forms.Button();
            this.CmdLoop3 = new System.Windows.Forms.Button();
            this.CmdLoop4 = new System.Windows.Forms.Button();
            this.LblLoop1 = new System.Windows.Forms.Label();
            this.LblLoop2 = new System.Windows.Forms.Label();
            this.LblLoop3 = new System.Windows.Forms.Label();
            this.LblLoop4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdLoopA
            // 
            this.CmdLoopA.Location = new System.Drawing.Point(13, 13);
            this.CmdLoopA.Name = "CmdLoopA";
            this.CmdLoopA.Size = new System.Drawing.Size(75, 23);
            this.CmdLoopA.TabIndex = 0;
            this.CmdLoopA.Text = "Schleife a)";
            this.CmdLoopA.UseVisualStyleBackColor = true;
            this.CmdLoopA.Click += new System.EventHandler(this.CmdLoopA_Click);
            // 
            // CmdLoop2
            // 
            this.CmdLoop2.Location = new System.Drawing.Point(137, 13);
            this.CmdLoop2.Name = "CmdLoop2";
            this.CmdLoop2.Size = new System.Drawing.Size(75, 23);
            this.CmdLoop2.TabIndex = 1;
            this.CmdLoop2.Text = "Schleife b)";
            this.CmdLoop2.UseVisualStyleBackColor = true;
            this.CmdLoop2.Click += new System.EventHandler(this.CmdLoop2_Click);
            // 
            // CmdLoop3
            // 
            this.CmdLoop3.Location = new System.Drawing.Point(257, 13);
            this.CmdLoop3.Name = "CmdLoop3";
            this.CmdLoop3.Size = new System.Drawing.Size(75, 23);
            this.CmdLoop3.TabIndex = 2;
            this.CmdLoop3.Text = "Schleife c)";
            this.CmdLoop3.UseVisualStyleBackColor = true;
            this.CmdLoop3.Click += new System.EventHandler(this.CmdLoop3_Click);
            // 
            // CmdLoop4
            // 
            this.CmdLoop4.Location = new System.Drawing.Point(372, 13);
            this.CmdLoop4.Name = "CmdLoop4";
            this.CmdLoop4.Size = new System.Drawing.Size(75, 23);
            this.CmdLoop4.TabIndex = 3;
            this.CmdLoop4.Text = "Schleife d)";
            this.CmdLoop4.UseVisualStyleBackColor = true;
            this.CmdLoop4.Click += new System.EventHandler(this.CmdLoop4_Click);
            // 
            // LblLoop1
            // 
            this.LblLoop1.AutoSize = true;
            this.LblLoop1.Location = new System.Drawing.Point(13, 58);
            this.LblLoop1.Name = "LblLoop1";
            this.LblLoop1.Size = new System.Drawing.Size(10, 13);
            this.LblLoop1.TabIndex = 4;
            this.LblLoop1.Text = ".";
            // 
            // LblLoop2
            // 
            this.LblLoop2.AutoSize = true;
            this.LblLoop2.Location = new System.Drawing.Point(137, 58);
            this.LblLoop2.Name = "LblLoop2";
            this.LblLoop2.Size = new System.Drawing.Size(10, 13);
            this.LblLoop2.TabIndex = 5;
            this.LblLoop2.Text = ".";
            // 
            // LblLoop3
            // 
            this.LblLoop3.AutoSize = true;
            this.LblLoop3.Location = new System.Drawing.Point(257, 58);
            this.LblLoop3.Name = "LblLoop3";
            this.LblLoop3.Size = new System.Drawing.Size(10, 13);
            this.LblLoop3.TabIndex = 6;
            this.LblLoop3.Text = ".";
            // 
            // LblLoop4
            // 
            this.LblLoop4.AutoSize = true;
            this.LblLoop4.Location = new System.Drawing.Point(372, 58);
            this.LblLoop4.Name = "LblLoop4";
            this.LblLoop4.Size = new System.Drawing.Size(10, 13);
            this.LblLoop4.TabIndex = 7;
            this.LblLoop4.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.LblLoop4);
            this.Controls.Add(this.LblLoop3);
            this.Controls.Add(this.LblLoop2);
            this.Controls.Add(this.LblLoop1);
            this.Controls.Add(this.CmdLoop4);
            this.Controls.Add(this.CmdLoop3);
            this.Controls.Add(this.CmdLoop2);
            this.Controls.Add(this.CmdLoopA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdLoopA;
        private System.Windows.Forms.Button CmdLoop2;
        private System.Windows.Forms.Button CmdLoop3;
        private System.Windows.Forms.Button CmdLoop4;
        private System.Windows.Forms.Label LblLoop1;
        private System.Windows.Forms.Label LblLoop2;
        private System.Windows.Forms.Label LblLoop3;
        private System.Windows.Forms.Label LblLoop4;
    }
}

