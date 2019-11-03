using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class DepoYonetim : System.Web.UI.Page
    {
        public stokEntities stDBGenel = new stokEntities();
        int pid;
        int kullaniciid;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ad"] != null)
            {
                kullaniciid = int.Parse(Session["id"].ToString());

                if (Request.QueryString["islem"] == "sil" && !string.IsNullOrEmpty(Request.QueryString["pid"].ToString()))
                {
                    try
                    {
                        pid = int.Parse(Request.QueryString["pid"]);

                        using (stokEntities db = new stokEntities())
                        {
                            users u2 = db.users.Find(kullaniciid);

                            if (u2.users_type != "admin")
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('İlgili Kullanıcı Misafir olduğundan silemez.')", true);

                            }
                            else
                            {

                                depo d = db.depo.Find(pid);
                                db.depo.Remove(d);
                                db.SaveChanges();
                                Response.Redirect("~/DepoYonetim.aspx");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Veritabanı bağlantı hatası: " + ex.Message + "')", true);
                    }
                }

                using (stokEntities db = new stokEntities())
                {
                    rptStok.DataSource = db.depo.ToList();
                    rptStok.DataBind();
                }
            }
        }

        public bool AdminMi()
        {
            string kullanici = stDBGenel.users.Find(int.Parse(Session["id"].ToString())).users_type;

            if (kullanici == "admin")
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