using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class KullaniciEkle : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
        }

        protected void btnKaydet1(object sender, EventArgs e)
        {
            
            using (stokEntities db = new stokEntities())
            {

                users u = new users();

                int varMi = db.users.Where(a => a.users_fname == txtad.Text && a.users_lname == txtsoyad.Text).Count();

                if (string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(drpUsertype.SelectedValue))

                {
                    Response.Write("<script>alert('Boşlukları Doldurun!');</script>");
                    temizle();

                }


                else if (varMi == 1)
                {
                    Response.Write("<script>alert('Kayıtlı zaten');</script>");
                    temizle();

                }


                else
                {
                    u.users_fname = txtad.Text.Trim();
                    u.users_lname = txtsoyad.Text.Trim();
                    u.users_mail = txtmail.Text.Trim();
                    u.users_type = drpUsertype.SelectedValue;
                    u.password = txtPassword.Text.Trim();
                    u.u_tarih = Convert.ToDateTime(DateTime.Now);

                    db.users.Add(u);
                    //var abc = db1.product.ToList();
                    db.SaveChanges();

                    Response.Write("Kayıt başarılı");

                    temizle();
                    Response.Redirect("~/KullaniciYonetim.aspx");
                }
            }
        }


        public void temizle()
        {
            txtad.Text = string.Empty;
            txtsoyad.Text = string.Empty;
            txtmail.Text = string.Empty;
            drpUsertype.SelectedValue = string.Empty;
            txtPassword.Text = string.Empty;

        }

      
    }
}