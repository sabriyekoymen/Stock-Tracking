using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class KullaniciYonetim : System.Web.UI.Page
    {
        public stokEntities stDBGenel = new stokEntities();
        int kullaniciid;
        int pid;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ad"] != null)
            {
                kullaniciid = int.Parse(Session["id"].ToString());

                if (!AdminMi())
                {
                    Response.Redirect("Giris.aspx");
                }

                if (Request.QueryString["islem"] == "sil" && !string.IsNullOrEmpty(Request.QueryString["pid"].ToString()))
                {
                    try
                    {
                        pid = int.Parse(Request.QueryString["pid"]);

                        using (stokEntities db = new stokEntities())
                        {

                            users u = db.users.Find(pid);
                            if (u.users_type != "admin")
                            {
                                db.users.Remove(u);
                                db.SaveChanges();           
                                ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('İlgili Kullanıcı başarılı bir şekilde silindi.');window.location.assign('KullaniciYonetim.aspx')", true);
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
                    users usr = db.users.Find(kullaniciid);
                    if (usr.users_type == "admin")
                    {
                        rptStok.DataSource = db.users.ToList();
                        rptStok.DataBind();
                    }
                    else
                    {
                        rptStok.DataSource = db.users.Where(a => a.users_type == "misafir").ToList();
                        rptStok.DataBind();
                    }

                }
            }
        }

        public bool AdminMi()
        {
            string userAktif = stDBGenel.users.Find(int.Parse(Session["id"].ToString())).users_type;

            if (userAktif == "admin")
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