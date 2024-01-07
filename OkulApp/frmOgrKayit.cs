using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class frmOgrKayit : Form
    {
        public int OgrenciId { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgrenciBL();

               bool sonuc=obl.OgrenciKaydet(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc?"Ekleme Başarılı":"Ekleme Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha Önce Kaydedilmiş");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Hata!");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            var frm=new frmOgrBul(this);
            frm.Show();
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciSil(OgrenciId) ? "Silme Başarılı" : "Başarısız");
            }
            catch(Exception)
            {
                MessageBox.Show("Bilinmeyen Hata");
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try { 
            var obl =new OgrenciBL();
            MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), OgrenciId = OgrenciId }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata");
            }
        }
    }
}
