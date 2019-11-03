using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class KullaniciDuzenle : System.Web.UI.Page
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
                            users u = db.users.Find(pid);
                            txtad.Text = u.users_fname;
                            txtsoyad.Text = u.users_lname;
                            txtmail.Text = u.users_mail;
                            //txttip.Text = u.users_type;
                            drpUsertype.SelectedValue = u.users_type;
                            txtPassword.Text = u.password;
                            

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
                    Response.Redirect("~/KullaniciYonetim.aspx");
                }


            }
        }


        protected void btnKaydet1(object sender, EventArgs e)
        {
            pid = int.Parse(Request.QueryString["pid"]);

            using (stokEntities db = new stokEntities())
            {

                // int varMi = db.users.Where(a => a.users_fname == txtad.Text && a.users_lname == txtsoyad.Text).Count();

                if (string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(drpUsertype.SelectedValue))

                {
                    Response.Write("<script>alert('Boşlukları Doldurun!');</script>");

                }

                else
                {

                    users u = db.users.Find(pid);
                    u.users_fname = txtad.Text;
                    u.users_lname = txtsoyad.Text;
                    u.users_mail = txtmail.Text;
                    u.users_type = drpUsertype.SelectedValue;
                    u.password = txtPassword.Text;
                    u.degistirme_tarihi = Convert.ToDateTime(DateTime.Now);

                    db.SaveChanges();
                    Response.Redirect("~/KullaniciYonetim.aspx");
                }
            }
        }
    }
}