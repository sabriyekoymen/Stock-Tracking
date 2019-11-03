using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class DepoDuzenle : System.Web.UI.Page
    {
        int pid;
        int kullaniciid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            kullaniciid = int.Parse(Session["id"].ToString());

            if (!Page.IsPostBack)
            {

                if (Request.QueryString["islem"] == "duzenle" && !string.IsNullOrEmpty(Request.QueryString["pid"].ToString()))
                {
                    try // Sayı ise devam et, yoksa hata ver
                    {
                        pid = int.Parse(Request.QueryString["pid"].ToString());
                        //pid = Convert.ToInt32(Request.QueryString["pid"].ToString());

                        using (stokEntities db = new stokEntities())
                        {
                            depo d  = db.depo.Find(pid);
                            txtad.Text = d.depo_name;
                         

                            users u2 = db.users.Find(kullaniciid);
                            if (u2.users_type != "admin")
                            {
                                btnKaydet.Visible = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //string msg
                        Response.Write("<script>alert('Hata!');</script>");
                    }


                }
                else
                {
                    Response.Redirect("~/DepoYonetim.aspx");
                }


            }
        }


        protected void btnKaydet1(object sender, EventArgs e)
        {
            pid = int.Parse(Request.QueryString["pid"]);

            using (stokEntities db = new stokEntities())
            {

                // int varMi = db.users.Where(a => a.users_fname == txtad.Text && a.users_lname == txtsoyad.Text).Count();

                if (string.IsNullOrWhiteSpace(txtad.Text) )

                {
                    Response.Write("<script>alert('Boşlukları Doldurun!');</script>");

                }

                else
                {

                    depo d = db.depo.Find(pid);
                    d.depo_name = txtad.Text;
                    

                    db.SaveChanges();
                    Response.Redirect("~/DepoYonetim.aspx");
                }
            }
        }
    }
}