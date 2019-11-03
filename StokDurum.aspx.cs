using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class StokDurum : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["ad"] == null)
            {
                Response.Redirect("Giris.aspx");
            }


            using (stokEntities db = new stokEntities())
            {

                var result = db.StkDurum
                  .Join(db.product,   //ürün adı için
                  s => s.product_id,
                  p => p.product_id,
                  (s, p) => new { s, p })
                  .Join(db.depo,       //depo adı için
                  o => o.s.depo_id,
                  d => d.depo_id,
                  (s1, d) => new { s1, d })
                  .Select(x => new
                  {
                      urunad = x.s1.p.product_name,
                      depoad = x.d.depo_name,
                      durum_olcu = x.s1.p.olcu_birimi,
                      stk_miktar=x.s1.s.stk_miktar,
                      //durum_olcu=x.s1.s.durum_olcu

                  }).ToList();


                Repeater1.DataSource = result;

                Repeater1.DataBind();

                //StkHareket hareket = new StkHareket();




                //var query = (from h in db.StkHareket

                //             join p in db.product on h.product_id equals p.product_id
                //             join d in db.depo on h.depo_nereden equals d.depo_id



                //             group h by new
                //             {
                //                 p.product_id,
                //                 d.depo_id,


                //             } into g


                //             select new
                //             {
                //                 g.Key.product_id,
                //                 g.Key.depo_id,

                //                 a = g.AsEnumerable().Sum(x => x.stk_miktar)

                //             }
                //    ).ToList();









            }
        }
    }
}
