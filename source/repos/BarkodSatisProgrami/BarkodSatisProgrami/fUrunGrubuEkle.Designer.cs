namespace BarkodSatisProgrami
{
    partial class fUrunGrubuEkle
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
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bEkle = new BarkodSatisProgrami.bStandart();
            this.tUrunGrupAd = new BarkodSatisProgrami.tStandart();
            this.lStandart1 = new BarkodSatisProgrami.lStandart();
            this.bSil = new BarkodSatisProgrami.bStandart();
            this.SuspendLayout();
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 25;
            this.listUrunGrup.Location = new System.Drawing.Point(34, 120);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(250, 204);
            this.listUrunGrup.TabIndex = 2;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::BarkodSatisProgrami.Properties.Resources.Ekle24;
            this.bEkle.Location = new System.Drawing.Point(165, 328);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(119, 79);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(34, 73);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(250, 30);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(29, 32);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(147, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Image = global::BarkodSatisProgrami.Properties.Resources.clear4848;
            this.bSil.Location = new System.Drawing.Point(34, 328);
            this.bSil.Margin = new System.Windows.Forms.Padding(1);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(109, 79);
            this.bSil.TabIndex = 0;
            this.bSil.Text = "Sil";
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 456);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private bStandart bEkle;
        private bStandart bSil;
    }
}