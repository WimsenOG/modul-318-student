namespace My_Transport_APP
{
    partial class Fahrplan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSucheVerbindung = new System.Windows.Forms.Button();
            this.dateTimePickerVerbindungsSuche = new System.Windows.Forms.DateTimePicker();
            this.coBoxVon = new System.Windows.Forms.ComboBox();
            this.coBoxNach = new System.Windows.Forms.ComboBox();
            this.btnSucheAbfahrtstaffel = new System.Windows.Forms.Button();
            this.dataGridViewVerbindungen = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAbfahrtsTafel = new System.Windows.Forms.DataGridView();
            this.coBoxAbfahrtstaffel = new System.Windows.Forms.ComboBox();
            this.labelAbfahrtstaffel = new System.Windows.Forms.Label();
            this.Von_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgrammBeenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtsTafel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSucheVerbindung
            // 
            this.btnSucheVerbindung.Location = new System.Drawing.Point(360, 45);
            this.btnSucheVerbindung.Name = "btnSucheVerbindung";
            this.btnSucheVerbindung.Size = new System.Drawing.Size(105, 23);
            this.btnSucheVerbindung.TabIndex = 0;
            this.btnSucheVerbindung.Text = "Suchen";
            this.btnSucheVerbindung.UseVisualStyleBackColor = true;
            this.btnSucheVerbindung.Click += new System.EventHandler(this.btnSucheVerbindung_Click);
            // 
            // dateTimePickerVerbindungsSuche
            // 
            this.dateTimePickerVerbindungsSuche.Location = new System.Drawing.Point(12, 46);
            this.dateTimePickerVerbindungsSuche.Name = "dateTimePickerVerbindungsSuche";
            this.dateTimePickerVerbindungsSuche.Size = new System.Drawing.Size(342, 22);
            this.dateTimePickerVerbindungsSuche.TabIndex = 2;
            // 
            // coBoxVon
            // 
            this.coBoxVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.coBoxVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.coBoxVon.FormattingEnabled = true;
            this.coBoxVon.Location = new System.Drawing.Point(48, 16);
            this.coBoxVon.Name = "coBoxVon";
            this.coBoxVon.Size = new System.Drawing.Size(182, 24);
            this.coBoxVon.TabIndex = 3;
            this.coBoxVon.SelectedIndexChanged += new System.EventHandler(this.coBoxVon_SelectedIndexChanged);
            this.coBoxVon.TextChanged += new System.EventHandler(this.coBoxVon_TextChanged);
            // 
            // coBoxNach
            // 
            this.coBoxNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.coBoxNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.coBoxNach.FormattingEnabled = true;
            this.coBoxNach.Location = new System.Drawing.Point(283, 16);
            this.coBoxNach.Name = "coBoxNach";
            this.coBoxNach.Size = new System.Drawing.Size(182, 24);
            this.coBoxNach.TabIndex = 4;
            this.coBoxNach.SelectedIndexChanged += new System.EventHandler(this.coBoxNach_SelectedIndexChanged);
            this.coBoxNach.TextChanged += new System.EventHandler(this.coBoxNach_TextChanged);
            // 
            // btnSucheAbfahrtstaffel
            // 
            this.btnSucheAbfahrtstaffel.Location = new System.Drawing.Point(259, 418);
            this.btnSucheAbfahrtstaffel.Name = "btnSucheAbfahrtstaffel";
            this.btnSucheAbfahrtstaffel.Size = new System.Drawing.Size(110, 23);
            this.btnSucheAbfahrtstaffel.TabIndex = 5;
            this.btnSucheAbfahrtstaffel.Text = "Suchen";
            this.btnSucheAbfahrtstaffel.UseVisualStyleBackColor = true;
            this.btnSucheAbfahrtstaffel.Click += new System.EventHandler(this.btnSucheAbfahrtstaffel_Click);
            // 
            // dataGridViewVerbindungen
            // 
            this.dataGridViewVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Abfahrt,
            this.Gleis,
            this.Verspätung});
            this.dataGridViewVerbindungen.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
            this.dataGridViewVerbindungen.RowHeadersWidth = 51;
            this.dataGridViewVerbindungen.RowTemplate.Height = 24;
            this.dataGridViewVerbindungen.Size = new System.Drawing.Size(686, 274);
            this.dataGridViewVerbindungen.TabIndex = 6;
            this.dataGridViewVerbindungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerbindungen_CellContentClick);
            // 
            // Von
            // 
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            this.Von.Width = 125;
            // 
            // Nach
            // 
            this.Nach.HeaderText = "Nach";
            this.Nach.MinimumWidth = 6;
            this.Nach.Name = "Nach";
            this.Nach.Width = 125;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 125;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.MinimumWidth = 6;
            this.Gleis.Name = "Gleis";
            this.Gleis.Width = 125;
            // 
            // Verspätung
            // 
            this.Verspätung.HeaderText = "Verspätung";
            this.Verspätung.MinimumWidth = 6;
            this.Verspätung.Name = "Verspätung";
            this.Verspätung.Width = 125;
            // 
            // dataGridViewAbfahrtsTafel
            // 
            this.dataGridViewAbfahrtsTafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbfahrtsTafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von_,
            this.Nach_,
            this.Abfahrt_,
            this.Zug});
            this.dataGridViewAbfahrtsTafel.Location = new System.Drawing.Point(12, 464);
            this.dataGridViewAbfahrtsTafel.Name = "dataGridViewAbfahrtsTafel";
            this.dataGridViewAbfahrtsTafel.RowHeadersWidth = 51;
            this.dataGridViewAbfahrtsTafel.RowTemplate.Height = 24;
            this.dataGridViewAbfahrtsTafel.Size = new System.Drawing.Size(686, 419);
            this.dataGridViewAbfahrtsTafel.TabIndex = 7;
            this.dataGridViewAbfahrtsTafel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // coBoxAbfahrtstaffel
            // 
            this.coBoxAbfahrtstaffel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.coBoxAbfahrtstaffel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.coBoxAbfahrtstaffel.FormattingEnabled = true;
            this.coBoxAbfahrtstaffel.Location = new System.Drawing.Point(12, 417);
            this.coBoxAbfahrtstaffel.Name = "coBoxAbfahrtstaffel";
            this.coBoxAbfahrtstaffel.Size = new System.Drawing.Size(241, 24);
            this.coBoxAbfahrtstaffel.TabIndex = 8;
            this.coBoxAbfahrtstaffel.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.coBoxAbfahrtstaffel.TextChanged += new System.EventHandler(this.coBoxAbfahrtstaffel_TextChanged);
            // 
            // labelAbfahrtstaffel
            // 
            this.labelAbfahrtstaffel.AutoSize = true;
            this.labelAbfahrtstaffel.Location = new System.Drawing.Point(12, 388);
            this.labelAbfahrtstaffel.Name = "labelAbfahrtstaffel";
            this.labelAbfahrtstaffel.Size = new System.Drawing.Size(100, 17);
            this.labelAbfahrtstaffel.TabIndex = 9;
            this.labelAbfahrtstaffel.Text = "Abfahrtstaffel :";
            this.labelAbfahrtstaffel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Von_
            // 
            this.Von_.HeaderText = "Von";
            this.Von_.MinimumWidth = 6;
            this.Von_.Name = "Von_";
            this.Von_.Width = 125;
            // 
            // Nach_
            // 
            this.Nach_.HeaderText = "Nach";
            this.Nach_.MinimumWidth = 6;
            this.Nach_.Name = "Nach_";
            this.Nach_.Width = 125;
            // 
            // Abfahrt_
            // 
            this.Abfahrt_.HeaderText = "Abfahrt";
            this.Abfahrt_.MinimumWidth = 6;
            this.Abfahrt_.Name = "Abfahrt_";
            this.Abfahrt_.Width = 125;
            // 
            // Zug
            // 
            this.Zug.HeaderText = "Zug";
            this.Zug.MinimumWidth = 6;
            this.Zug.Name = "Zug";
            this.Zug.Width = 125;
            // 
            // ProgrammBeenden
            // 
            this.ProgrammBeenden.Location = new System.Drawing.Point(623, 889);
            this.ProgrammBeenden.Name = "ProgrammBeenden";
            this.ProgrammBeenden.Size = new System.Drawing.Size(75, 23);
            this.ProgrammBeenden.TabIndex = 10;
            this.ProgrammBeenden.Text = "Schliessen";
            this.ProgrammBeenden.UseVisualStyleBackColor = true;
            this.ProgrammBeenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nach";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 1035);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgrammBeenden);
            this.Controls.Add(this.labelAbfahrtstaffel);
            this.Controls.Add(this.coBoxAbfahrtstaffel);
            this.Controls.Add(this.dataGridViewAbfahrtsTafel);
            this.Controls.Add(this.dataGridViewVerbindungen);
            this.Controls.Add(this.btnSucheAbfahrtstaffel);
            this.Controls.Add(this.coBoxNach);
            this.Controls.Add(this.coBoxVon);
            this.Controls.Add(this.dateTimePickerVerbindungsSuche);
            this.Controls.Add(this.btnSucheVerbindung);
            this.Name = "Fahrplan";
            this.Text = "er";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtsTafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSucheVerbindung;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerbindungsSuche;
        private System.Windows.Forms.ComboBox coBoxVon;
        private System.Windows.Forms.ComboBox coBoxNach;
        private System.Windows.Forms.Button btnSucheAbfahrtstaffel;
        private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
        private System.Windows.Forms.DataGridView dataGridViewAbfahrtsTafel;
        private System.Windows.Forms.ComboBox coBoxAbfahrtstaffel;
        private System.Windows.Forms.Label labelAbfahrtstaffel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zug;
        private System.Windows.Forms.Button ProgrammBeenden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}