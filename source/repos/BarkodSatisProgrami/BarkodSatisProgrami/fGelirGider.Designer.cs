namespace BarkodSatisProgrami
{
    partial class fGelirGider
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
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.bEkle = new BarkodSatisProgrami.bStandart();
            this.lStandart6 = new BarkodSatisProgrami.lStandart();
            this.tAciklama = new BarkodSatisProgrami.tStandart();
            this.lStandart5 = new BarkodSatisProgrami.lStandart();
            this.lStandart4 = new BarkodSatisProgrami.lStandart();
            this.lStandart3 = new BarkodSatisProgrami.lStandart();
            this.tKart = new BarkodSatisProgrami.tNumeric();
            this.tNakit = new BarkodSatisProgrami.tNumeric();
            this.lStandart2 = new BarkodSatisProgrami.lStandart();
            this.lGelirGider = new BarkodSatisProgrami.lStandart();
            this.SuspendLayout();
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "KART-NAKİT"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(17, 87);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(246, 33);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(23, 413);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(252, 27);
            this.dtTarih.TabIndex = 10;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::BarkodSatisProgrami.Properties.Resources.Ekle24;
            this.bEkle.Location = new System.Drawing.Point(72, 462);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(140, 73);
            this.bEkle.TabIndex = 12;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(18, 385);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(57, 25);
            this.lStandart6.TabIndex = 11;
            this.lStandart6.Text = "Tarih";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(17, 234);
            this.tAciklama.Multiline = true;
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(246, 130);
            this.tAciklama.TabIndex = 9;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(13, 196);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(92, 25);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Açıklama";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(155, 123);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(48, 25);
            this.lStandart4.TabIndex = 7;
            this.lStandart4.Text = "Kart";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(13, 123);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(56, 25);
            this.lStandart3.TabIndex = 6;
            this.lStandart3.Text = "Nakit";
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(159, 151);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(104, 30);
            this.tKart.TabIndex = 5;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(18, 151);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(118, 30);
            this.tNakit.TabIndex = 4;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(12, 49);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(123, 25);
            this.lStandart2.TabIndex = 3;
            this.lStandart2.Text = "Ödeme Türü";
            this.lStandart2.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelirGider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGelirGider.Location = new System.Drawing.Point(13, 13);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(134, 25);
            this.lGelirGider.TabIndex = 0;
            this.lGelirGider.Text = "GELİR GİDER";
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 588);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.lStandart6);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.tAciklama);
            this.Controls.Add(this.lStandart5);
            this.Controls.Add(this.lStandart4);
            this.Controls.Add(this.lStandart3);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.lStandart2);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lGelirGider);
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GELİR-GİDER İŞLEMLERİ";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lGelirGider;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private lStandart lStandart2;
        private tNumeric tNakit;
        private tNumeric tKart;
        private lStandart lStandart3;
        private lStandart lStandart4;
        private lStandart lStandart5;
        private tStandart tAciklama;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private lStandart lStandart6;
        private bStandart bEkle;
    }
}