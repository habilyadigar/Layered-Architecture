﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusniesLogicLayer;
using DataAccessLayer;

namespace OOPSTOK
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityUrun ent = new EntityUrun();
            ent.Urunad = TextBox1.Text;
            ent.Urunadet = int.Parse(TextBox2.Text);
            ent.Urunfiyat = decimal.Parse(TextBox3.Text);
            BLLUrun.BLLUrunEkle(ent);


        }
    }
}