using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class Profil : System.Web.UI.Page
    {

        int kullaniciid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }

            if (!Page.IsPostBack)
            {
                kullaniciid = int.Parse(Session["id"].ToString());

                try // Sayı ise devam et, yoksa hata ver
                {


                    using (stokEntities db = new stokEntities())
                    {
                        users u = db.users.Find(kullaniciid);
                        txtad.Text = u.users_fname;
                        txtsoyad.Text = u.users_lname;
                        txtmail.Text = u.users_mail;
                        txtpassword.Text = u.password;


                    }
                }
                catch (Exception)
                {
                    //string msg
                    Response.Write("<script>alert('Hata! id değeri yanlış formatta girildi.');</script>");
                }

            }

        }

        protected void btnKaydet1(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            kullaniciid = int.Parse(Session["id"].ToString());

            using (stokEntities db = new stokEntities())
            {

                if (string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text))

                {
                    Response.Write("<script>alert('Boşlukları Doldurun!');</script>");

                }

                else
                {

                    users u = db.users.Find(kullaniciid);
                    u.users_fname = txtad.Text.Trim();
                    u.users_lname = txtsoyad.Text.Trim();
                    u.users_mail = txtmail.Text.Trim();
                    // u.password = txtPassword.Text.Trim();
                    u.degistirme_tarihi = Convert.ToDateTime(DateTime.Now);


                    db.SaveChanges();
                    // Session.Abandon();
                    ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Bilgiler başarılı bir şekilde değiştirildi.')", true);

                }
            }




        }

        protected void btnsifre_Click(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            kullaniciid = int.Parse(Session["id"].ToString());

            using (stokEntities db = new stokEntities())
            {

                if (string.IsNullOrWhiteSpace(txtpassword.Text))

                {
                    Response.Write("<script>alert('Boşlukları Doldurun!');</script>");

                }

                else
                {

                    users u = db.users.Find(kullaniciid);
                    u.password = txtpassword.Text.Trim();

                    db.SaveChanges();
                    Session.Abandon();
                    ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Şifreniz başarılı bir şekilde değiştirildi.\\nGiriş sayfasına yönlendiriliyorsunuz.');window.location.assign('Giris.aspx')", true);

                }
            }

        }
    }
}