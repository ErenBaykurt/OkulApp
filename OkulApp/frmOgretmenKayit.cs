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
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnKaydett_Click(object sender, EventArgs e)
        {
            try
            {
                var ogbl = new OgretmenBL();

                bool sonuc = ogbl.OgretmenKaydet(new Ogretmen { Add = txtAdd.Text.Trim(), Soyadd = txtSoyadd.Text.Trim(), Tc = txtTc.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu kimliknumarası daha Önce Kaydedilmiş");
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
    }
}
