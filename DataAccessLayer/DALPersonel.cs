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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();

            SqlCommand komut = new SqlCommand("DEPARTMANLIST", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid = int.Parse(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();          
                ent.Personelmaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                ent.Personeldep = dr["DEPARTMANAD"].ToString();              
                //ent.Personeldepartman = byte.Parse(dr["PERSONELDEPARTMAN"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel u)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) values (@U1,@U2,@U3,@U4)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@U1", u.Personelad);
            komut1.Parameters.AddWithValue("@U2", u.Personelsoyad);
            komut1.Parameters.AddWithValue("@U3", u.Personeldepartman);
            komut1.Parameters.AddWithValue("@U4", u.Personelmaas);
            return komut1.ExecuteNonQuery();
        }


    }
}
