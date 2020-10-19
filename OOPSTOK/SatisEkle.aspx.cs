using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using BusniesLogicLayer;

namespace OOPSTOK
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownUrun.DataValueField = "URUNID";
                DropDownUrun.DataTextField = "URUNAD";
                DropDownUrun.DataSource = dt;
                DropDownUrun.DataBind();


                SqlCommand komut2 = new SqlCommand("SELECT PERSONELID, (PERSONELAD + ' ' + PERSONELSOYAD) AS 'PERSONELAD' FROM TBLPERSONEL" ,Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownPersonel.DataValueField = "PERSONELID";
                DropDownPersonel.DataTextField = "PERSONELAD";
                DropDownPersonel.DataSource = dt2;
                DropDownPersonel.DataBind();

                SqlCommand komut3 = new SqlCommand("SELECT MUSTERIID, (MUSTERIAD + ' ' + MUSTERISOYAD) AS 'MUSTERIADSOYAD' FROM TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownMusteri.DataValueField = "MUSTERIID";
                DropDownMusteri.DataTextField = "MUSTERIADSOYAD";
                DropDownMusteri.DataSource = dt3;
                DropDownMusteri.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitySatis ent = new EntitySatis();
            ent.Fiyat = decimal.Parse(TextBox3.Text);
            ent.Urun = byte.Parse(DropDownUrun.SelectedValue);
            ent.Personel = byte.Parse(DropDownPersonel.SelectedValue);
            ent.Musteri = byte.Parse(DropDownMusteri.SelectedValue);
            BLLSatis.BLLSatisEkle(ent);

        }
    }
}