using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class DepoEkle : System.Web.UI.Page
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

                depo d = new depo();
                d.depo_name=txtad.Text.Trim();
                

                db.depo.Add(d);
                //var abc = db1.product.ToList();
                db.SaveChanges();

                Response.Write("Kayıt başarılı");

                temizle();
                Response.Redirect("~/DepoYonetim.aspx");
            }
        }


        public void temizle()
        {
            txtad.Text = string.Empty;
            
        }

        //protected void btndepovazgec_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/DepoYonetim.aspx");
        //}
    }
}