using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogrtm)
        {
            var hlp = new Helper();
            var p = new SqlParameter[]
            {
                new SqlParameter("@Ad",ogrtm.Add),
                new SqlParameter("@Soyad",ogrtm.Soyadd),
                new SqlParameter("@Tc",ogrtm.Tc)
            };
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values (@Ad,@Soyad,@Tc)", p) > 0;
        }
    }
}
