using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();

           

        }

        protected void btnlogin(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (stokEntities db = new stokEntities())
            {
                
                int varMi = db.users.Where(a => a.users_fname == txtUsername.Text && a.password == txtPassword.Text).Count();


                if (varMi == 1)
                {
                    Session["id"] = db.users.Where(a => a.users_fname == txtUsername.Text && a.password == txtPassword.Text).FirstOrDefault().users_id;
                    Session["ad"] = txtUsername.Text;
                   
                    Response.Redirect("~/Anasayfa.aspx");
                }
                else
                {
                    dvMessage.Visible = true;
                    lblMessage.Text = "Username and/or password is incorrect.";
                }
            }

        }


    }
}