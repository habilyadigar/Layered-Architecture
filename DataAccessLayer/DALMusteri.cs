using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri m)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) values (@m1,@m2)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@m1", m.Musteriad);
            komut1.Parameters.AddWithValue("@m2", m.Musterisoyad);
            return komut1.ExecuteNonQuery();
        }
        public static bool MusteriSil(int p)
        {
            SqlCommand komut2 = new SqlCommand("DELETE From TBLMUSTERI WHERE MUSTERIID = @P1", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p);
            return komut2.ExecuteNonQuery() > 0;
        }
        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI where MUSTERIID = @p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                //ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool MusteriGuncelle(EntityMusteri m)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBLMUSTERI SET MUSTERIAD=@P1, MUSTERISOYAD = @P2 WHERE MUSTERIID = @P3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", m.Musteriad);
            komut.Parameters.AddWithValue("@P2", m.Musterisoyad);
            komut.Parameters.AddWithValue("@P3", m.Musteriid);
            return komut.ExecuteNonQuery() > 0;

        }


    }
}
