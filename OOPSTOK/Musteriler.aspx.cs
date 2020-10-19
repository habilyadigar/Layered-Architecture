using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusniesLogicLayer;

namespace OOPSTOK
{
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> MusLis = BLLMusteri.BLLMusteriListesi();
            Repeater1.DataSource = MusLis;
            Repeater1.DataBind();
        }
    }
}