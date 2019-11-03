using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        public stokEntities stDBGenel = new stokEntities();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            else
            {
                lblUserName.Text = Session["ad"].ToString();

            } 

            //önceki sayfalar logout dedikten sonra çıkmasın diye
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Giris.aspx");
        }

        public bool IsAdmin()
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