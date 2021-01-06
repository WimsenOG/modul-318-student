namespace My_Transport_APP
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
            this.Label_Titel_SBB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Titel_SBB
            // 
            this.Label_Titel_SBB.AutoSize = true;
            this.Label_Titel_SBB.Location = new System.Drawing.Point(65, 50);
            this.Label_Titel_SBB.Name = "Label_Titel_SBB";
            this.Label_Titel_SBB.Size = new System.Drawing.Size(35, 17);
            this.Label_Titel_SBB.TabIndex = 0;
            this.Label_Titel_SBB.Text = "SBB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Titel_SBB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Titel_SBB;
    }
}

