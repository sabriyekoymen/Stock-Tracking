using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class StokHareketListe : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }

            using (stokEntities db = new stokEntities())
            {



                var result = db.StkHareket
                 .Join(db.product,   //ürün adı için
                 s => s.product_id,
                 p => p.product_id,
                 (s, p) => new { s, p })
                 .Join(db.depo,       //depo adı için
                 o => o.s.depo_id,
                 d => d.depo_id,
                 (s1, d) => new { s1, d })
                 //.OrderByDescending(x => x.s1.s.hareket_tarih)
                 .Select(x => new
                 {
                     urunad = x.s1.p.product_name,
                     depoad = x.d.depo_name,
                     hareket_turu=x.s1.s.hareket_turu,
                     stk_miktar=x.s1.s.stk_miktar,
                     stk_olcu=x.s1.s.stk_olcu,
                     user_name=x.s1.s.user_name,
                     hareket_tarih=x.s1.s.hareket_tarih



                 }).OrderByDescending(x=>x.hareket_tarih).ToList();



                rptStok.DataSource = result;
                rptStok.DataBind();


            }
        }
    }
}