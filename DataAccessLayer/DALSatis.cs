using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DALSatis
    {
        public static List<EntitySatis> SatisListesi()
        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.Satisid = int.Parse(dr["SATISID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int SatisEkle(EntitySatis u)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLSATIS (URUN,PERSONEL,TUTAR,MUSTERI) values (@U1,@U2,@U3,@U4)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@U1", u.Urun);
            komut1.Parameters.AddWithValue("@U2", u.Personel);
            komut1.Parameters.AddWithValue("@U3", u.Fiyat);
            komut1.Parameters.AddWithValue("@U4", u.Musteri);
            return komut1.ExecuteNonQuery();
        }




    }
}
