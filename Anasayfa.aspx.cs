using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        public stokEntities stDBGenel = new stokEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }

        }


        public bool AdminMi()
        {
            string aktifkullanici = stDBGenel.users.Find(int.Parse(Session["id"].ToString())).users_type;
            if (aktifkullanici == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}