using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class StokEkle : System.Web.UI.Page
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
            using (stokEntities db1 = new stokEntities())
            {

                product p1 = new product();
                p1.product_name = txtad.Text.Trim();
                p1.product_date = Convert.ToDateTime(DateTime.Now);
                p1.degistirme_tarihi = Convert.ToDateTime(DateTime.Now);
                p1.product_detail = txtdetay.Text.Trim();

                db1.product.Add(p1);
                //var abc = db1.product.ToList();
                db1.SaveChanges();

                Response.Write("Kayıt başarılı");
                
                temizle();
                Response.Redirect("~/StokYonetim.aspx");
            }
        }

        public void temizle()
        {
            txtad.Text = string.Empty;
            txtdetay.Text = string.Empty;
           

        }
        
       
    }
}