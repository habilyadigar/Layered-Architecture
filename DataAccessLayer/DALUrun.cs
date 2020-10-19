using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("SELECT *FROM TBLURUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = byte.Parse(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.Urunadet = int.Parse(dr["URUNADET"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int UrunEkle(EntityUrun u)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLURUN (URUNAD,URUNFIYAT,URUNADET) values (@U1,@U2,@U3)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@U1", u.Urunad);
            komut1.Parameters.AddWithValue("@U2", u.Urunfiyat);
            komut1.Parameters.AddWithValue("@U3", u.Urunadet);
            return komut1.ExecuteNonQuery();
        }

    }
}
