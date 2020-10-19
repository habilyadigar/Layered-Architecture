using System;
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
    public partial class Satislar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntitySatis> SatisListesi = BLLSatis.BLLSatisListesi();
            Repeater1.DataSource = SatisListesi ;
            Repeater1.DataBind();
        }
    }
}