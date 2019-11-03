using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class YeniKayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 
        protected void btnKaydet1(object sender, EventArgs e)
        {
            
                using (stokEntities db=new stokEntities())
            {
                users usr = new users();
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
                    usr.users_fname = txtad.Text;
                    usr.users_lname = txtsoyad.Text;
                    usr.users_mail = txtmail.Text;
                    usr.users_type = drpUsertype.SelectedValue;
                    usr.password = txtPassword.Text;
                    db.users.Add(usr);

                    db.SaveChanges();
                   


                    temizle();
                    Response.Redirect("~/Giris.aspx" );
                    Response.Write("<script>alert('Kayıt Başarılı!');</script>");
                    
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