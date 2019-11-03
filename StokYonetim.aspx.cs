using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class StokYonetim : System.Web.UI.Page
    {
        int pid;
        int kullaniciid;
        stokEntities stDBGenel = new stokEntities();

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
                                product p = db.product.Find(pid);
                                db.product.Remove(p);
                                db.SaveChanges();
                                Response.Redirect("~/StokYonetim.aspx");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Veritabanı bağlantı hatası: " + ex.Message + "')", true);
                    }
                }
            }



            using (stokEntities db = new stokEntities())
            {

                rptStok.DataSource = db.product.ToList();
                rptStok.DataBind();

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