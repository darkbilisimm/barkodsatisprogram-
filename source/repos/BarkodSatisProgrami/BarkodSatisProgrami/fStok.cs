using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodSatisProgrami
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new barkoddbEntities())
            {
                if (cmbIslemTuru.Text!="")
                {
                    string urungrubu = cmbIslemTuru.Text;
                    if (cmbIslemTuru.SelectedIndex==0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex==1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.Stok_Hareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridListe.DataSource = db.Stok_Hareket.Local.ToBindingList();
                        }else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Stok_Hareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.Stok_Hareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen işlem türünü seçiniz");
                }
            }
            Islemler.GridDuzenle(gridListe);
        }

        barkoddbEntities dbx = new barkoddbEntities();
        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length>=3)
            {
                string urunad = tUrunAra.Text;
                using (var db = new barkoddbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex==0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex==1)
                    {
                        db.Stok_Hareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Stok_Hareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe);
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            Cursor.Current = Cursors.Default;
        }
    }
}
