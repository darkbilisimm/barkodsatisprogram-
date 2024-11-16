namespace BarkodSatisProgrami
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lStandart1 = new BarkodSatisProgrami.lStandart();
            this.bAra = new BarkodSatisProgrami.bStandart();
            this.lStandart5 = new BarkodSatisProgrami.lStandart();
            this.lStandart4 = new BarkodSatisProgrami.lStandart();
            this.lStandart3 = new BarkodSatisProgrami.lStandart();
            this.lStandart2 = new BarkodSatisProgrami.lStandart();
            this.tUrunAra = new BarkodSatisProgrami.tStandart();
            this.lStandart6 = new BarkodSatisProgrami.lStandart();
            this.gridListe = new BarkodSatisProgrami.gridOzel();
            this.bRaporAl = new BarkodSatisProgrami.bStandart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 784);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbIslemTuru);
            this.panel4.Controls.Add(this.lStandart1);
            this.panel4.Location = new System.Drawing.Point(18, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 83);
            this.panel4.TabIndex = 8;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(3, 38);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(246, 33);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitis);
            this.panelTarihler.Controls.Add(this.lStandart5);
            this.panelTarihler.Controls.Add(this.lStandart4);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Location = new System.Drawing.Point(15, 331);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(258, 173);
            this.panelTarihler.TabIndex = 7;
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(3, 126);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(252, 27);
            this.dateBitis.TabIndex = 3;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(3, 53);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(252, 27);
            this.dateBaslangic.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lStandart3);
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(18, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 100);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(3, 47);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(249, 33);
            this.cmbUrunGrubu.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lStandart2);
            this.panel1.Controls.Add(this.rdUrunGrubunaGore);
            this.panel1.Controls.Add(this.rdTumu);
            this.panel1.Location = new System.Drawing.Point(18, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 100);
            this.panel1.TabIndex = 4;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Checked = true;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(3, 71);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(143, 20);
            this.rdUrunGrubunaGore.TabIndex = 3;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Location = new System.Drawing.Point(3, 45);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(62, 20);
            this.rdTumu.TabIndex = 3;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(945, 784);
            this.splitContainer2.SplitterDistance = 53;
            this.splitContainer2.TabIndex = 0;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(5, 10);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(104, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "İşlem Türü";
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Image = global::BarkodSatisProgrami.Properties.Resources.ara3232;
            this.bAra.Location = new System.Drawing.Point(52, 530);
            this.bAra.Margin = new System.Windows.Forms.Padding(1);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(140, 73);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Ara";
            this.bAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(8, 97);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(102, 25);
            this.lStandart5.TabIndex = 2;
            this.lStandart5.Text = "Bitiş Tarihi";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(8, 15);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(151, 25);
            this.lStandart4.TabIndex = 1;
            this.lStandart4.Text = "Başlangıç Tarihi";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(3, 10);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(113, 25);
            this.lStandart3.TabIndex = 6;
            this.lStandart3.Text = "Ürün Grubu";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(3, 17);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(142, 25);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Filtreleme Türü";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(129, 16);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(379, 30);
            this.tUrunAra.TabIndex = 1;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(32, 22);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(90, 25);
            this.lStandart6.TabIndex = 0;
            this.lStandart6.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 40;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(945, 727);
            this.gridListe.TabIndex = 1;
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.Color.Teal;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("bRaporAl.Image")));
            this.bRaporAl.Location = new System.Drawing.Point(537, 16);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(140, 30);
            this.bRaporAl.TabIndex = 14;
            this.bRaporAl.Text = "Rapor Al";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            this.bRaporAl.Click += new System.EventHandler(this.bRaporAl_Click);
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1225, 784);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private lStandart lStandart2;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdTumu;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lStandart lStandart1;
        private System.Windows.Forms.Panel panel2;
        private lStandart lStandart3;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private lStandart lStandart5;
        private lStandart lStandart4;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private bStandart bAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart tUrunAra;
        private lStandart lStandart6;
        private gridOzel gridListe;
        private bStandart bRaporAl;
    }
}