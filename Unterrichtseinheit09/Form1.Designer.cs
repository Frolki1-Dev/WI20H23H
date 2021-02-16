
namespace Unterrichtseinheit09
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
            this.LstData = new System.Windows.Forms.ListBox();
            this.CmdShowOneElement = new System.Windows.Forms.Button();
            this.CmdShowAllElements = new System.Windows.Forms.Button();
            this.CmdShowSelectedElement = new System.Windows.Forms.Button();
            this.CmdShowAllSelectedElements = new System.Windows.Forms.Button();
            this.CmdShowAllElementsWithForEach = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Die Listbox";
            // 
            // LstData
            // 
            this.LstData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstData.FormattingEnabled = true;
            this.LstData.ItemHeight = 25;
            this.LstData.Location = new System.Drawing.Point(19, 82);
            this.LstData.Name = "LstData";
            this.LstData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstData.Size = new System.Drawing.Size(271, 254);
            this.LstData.TabIndex = 1;
            // 
            // CmdShowOneElement
            // 
            this.CmdShowOneElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShowOneElement.Location = new System.Drawing.Point(315, 82);
            this.CmdShowOneElement.Name = "CmdShowOneElement";
            this.CmdShowOneElement.Size = new System.Drawing.Size(377, 34);
            this.CmdShowOneElement.TabIndex = 2;
            this.CmdShowOneElement.Text = "Zeige ein Element >>";
            this.CmdShowOneElement.UseVisualStyleBackColor = true;
            this.CmdShowOneElement.Click += new System.EventHandler(this.CmdShowOneElement_Click);
            // 
            // CmdShowAllElements
            // 
            this.CmdShowAllElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShowAllElements.Location = new System.Drawing.Point(315, 136);
            this.CmdShowAllElements.Name = "CmdShowAllElements";
            this.CmdShowAllElements.Size = new System.Drawing.Size(377, 34);
            this.CmdShowAllElements.TabIndex = 3;
            this.CmdShowAllElements.Text = "Zeige alle Elemente >>";
            this.CmdShowAllElements.UseVisualStyleBackColor = true;
            this.CmdShowAllElements.Click += new System.EventHandler(this.CmdShowAllElements_Click);
            // 
            // CmdShowSelectedElement
            // 
            this.CmdShowSelectedElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShowSelectedElement.Location = new System.Drawing.Point(315, 190);
            this.CmdShowSelectedElement.Name = "CmdShowSelectedElement";
            this.CmdShowSelectedElement.Size = new System.Drawing.Size(377, 34);
            this.CmdShowSelectedElement.TabIndex = 4;
            this.CmdShowSelectedElement.Text = "Zeige selektiertes Element >>";
            this.CmdShowSelectedElement.UseVisualStyleBackColor = true;
            this.CmdShowSelectedElement.Click += new System.EventHandler(this.CmdShowSelectedElement_Click);
            // 
            // CmdShowAllSelectedElements
            // 
            this.CmdShowAllSelectedElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShowAllSelectedElements.Location = new System.Drawing.Point(315, 244);
            this.CmdShowAllSelectedElements.Name = "CmdShowAllSelectedElements";
            this.CmdShowAllSelectedElements.Size = new System.Drawing.Size(377, 34);
            this.CmdShowAllSelectedElements.TabIndex = 5;
            this.CmdShowAllSelectedElements.Text = "Zeige selektierte Elemente >>";
            this.CmdShowAllSelectedElements.UseVisualStyleBackColor = true;
            this.CmdShowAllSelectedElements.Click += new System.EventHandler(this.CmdShowAllSelectedElements_Click);
            // 
            // CmdShowAllElementsWithForEach
            // 
            this.CmdShowAllElementsWithForEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShowAllElementsWithForEach.Location = new System.Drawing.Point(315, 299);
            this.CmdShowAllElementsWithForEach.Name = "CmdShowAllElementsWithForEach";
            this.CmdShowAllElementsWithForEach.Size = new System.Drawing.Size(377, 34);
            this.CmdShowAllElementsWithForEach.TabIndex = 6;
            this.CmdShowAllElementsWithForEach.Text = "Zeige alle Elemente mit foreach >>";
            this.CmdShowAllElementsWithForEach.UseVisualStyleBackColor = true;
            this.CmdShowAllElementsWithForEach.Click += new System.EventHandler(this.CmdShowAllElementsWithForEach_Click);
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtData.Location = new System.Drawing.Point(733, 82);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(275, 251);
            this.TxtData.TabIndex = 7;
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(315, 40);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(377, 29);
            this.TxtInput.TabIndex = 8;
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 369);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.CmdShowAllElementsWithForEach);
            this.Controls.Add(this.CmdShowAllSelectedElements);
            this.Controls.Add(this.CmdShowSelectedElement);
            this.Controls.Add(this.CmdShowAllElements);
            this.Controls.Add(this.CmdShowOneElement);
            this.Controls.Add(this.LstData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.Button CmdShowOneElement;
        private System.Windows.Forms.Button CmdShowAllElements;
        private System.Windows.Forms.Button CmdShowSelectedElement;
        private System.Windows.Forms.Button CmdShowAllSelectedElements;
        private System.Windows.Forms.Button CmdShowAllElementsWithForEach;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtInput;
    }
}

