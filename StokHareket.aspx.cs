using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stoktakip2
{
    public partial class StokHareket : System.Web.UI.Page
    {
        stokEntities stkdb = new stokEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                using (stokEntities db = new stokEntities())
                {

                    

                    //sadece kayıtlı olanları seçmek için dropdownliste gönderiyor...
                    drpStok.DataSource = db.product.ToList();
                    drpStok.DataTextField = "product_name";
                    drpStok.DataValueField = "product_id";
                    drpStok.DataBind();
                    drpStok.Items.Insert(0, new ListItem("Ürün Seçiniz", " "));


                    drpDepo.DataSource = db.depo.ToList();
                    drpDepo.DataTextField = "depo_name";
                    drpDepo.DataValueField = "depo_id";
                    drpDepo.DataBind();
                    drpDepo.Items.Insert(0, new ListItem("Depo Seçiniz", " "));


                }

            }
        }

        protected void btnKaydet1(object sender, EventArgs e)
        {

            using (stokEntities db = new stokEntities())
            {

                StkHareket stkHareket = new StkHareket();

                //ölçü birimi ve hareket türü seçimleri yapılmamışsa hata ver
                if (string.IsNullOrWhiteSpace(drpHareket.SelectedValue) || string.IsNullOrWhiteSpace(drpStok.SelectedValue) || string.IsNullOrWhiteSpace(drpDepo.SelectedValue))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Lütfen seçim yapınız!')", true);
                }

                //boş kalan alan yoksa...
                else
                {
                    stkHareket.product_id = int.Parse(drpStok.SelectedValue);
                    stkHareket.depo_id = int.Parse(drpDepo.SelectedValue);
                    stkHareket.user_name = Session["ad"].ToString();
                    stkHareket.hareket_tarih = Convert.ToDateTime(DateTime.Now);                  
                    stkHareket.stk_miktar = Convert.ToInt32(txtmiktar.Text);
                    stkHareket.hareket_turu = drpHareket.SelectedValue;
                    stkHareket.stk_olcu = txtolcubirim.Text;


                    // stkdurum tablosunu güncelle

                    int stkDurumVarMi = db.StkDurum.Where(a => a.depo_id == stkHareket.depo_id && a.product_id == stkHareket.product_id).Count();
                    // kayıt var mı diye kontrol et
                    if (stkDurumVarMi > 0)
                    {
                        //önceki kaydın id sini bul
                        int durumid = db.StkDurum.Where(a => a.depo_id == stkHareket.depo_id && a.product_id == stkHareket.product_id).FirstOrDefault().durum_id;
                        StkDurum d = db.StkDurum.Find(durumid);
                        

                        //eğer işlem çıkışsa ve stoktaki miktardan fazlaysa işlemi yaptırma
                        if (stkHareket.hareket_turu == "Cıkıs" && d.stk_miktar < stkHareket.stk_miktar)
                        {
                            string hatamesaj = "alert('En fazla " + d.stk_miktar.ToString() + " " + stkHareket.stk_olcu + " çıkış yapabilirsiniz');";
                            ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", hatamesaj, true);
                        }

                        //işlem çıkışsa ve stoktaki miktardan azsa  miktarı güncelle
                        else if (stkHareket.hareket_turu == "Cıkıs" && d.stk_miktar >= stkHareket.stk_miktar)
                        {
                            //Aynı üründen aynı ölçü birimiyle çıkış yapılırsa...
                            //if (d.durum_olcu == stkHareket.stk_olcu)
                            //{
                            d.stk_miktar = d.stk_miktar - stkHareket.stk_miktar;
                           //stkHareket.stk_olcu = d.durum_olcu;
                            db.StkHareket.Add(stkHareket); // stok hareketi eklendi
                            db.SaveChanges();
                            ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Stok başarılı bir şekilde güncellendi.');window.location.assign('StokHareketListe.aspx')", true);

                            // }
                            //Aynı üründen farklı ölçü birimiyle çıkış yapılırsa...
                            //else
                            //{
                            //    ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Ölçü Birimi Hatalı!')", true);
                            //}
                        }

                        //işlem girişse güncelle
                        else
                        {
                            //Aynı üründen aynı ölçü birimiyle giriş yapılırsa..
                            //if (d.durum_olcu == stkHareket.stk_olcu)
                            //{
                            d.stk_miktar = d.stk_miktar + stkHareket.stk_miktar;
                            //stkHareket.stk_olcu = d.durum_olcu;
                            db.StkHareket.Add(stkHareket); // stok hareketi eklendi
                            db.SaveChanges();
                            ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Stok başarılı bir şekilde güncellendi.');window.location.assign('StokHareketListe.aspx')", true);
                            // }

                            //Aynı üründen farklı ölçü birimiyle giriş yapılırsa...
                            //else
                            //{
                            //    ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Ölçü Birimi Hatalı!')", true);
                            //}
                        }
                    }
                    // yeni stkDurum kaydı oluştur, girilen değeri miktara yaz
                    else
                    {
                        //daha önce kayıt yok ve işlem girişse işlemi yaptır
                        if (stkHareket.hareket_turu != "Cıkıs")
                        {
                            string mesaj = "alert('Stok eklendi!');";
                            StkDurum durum = new StkDurum();
                            durum.product_id = stkHareket.product_id;
                            durum.depo_id = stkHareket.depo_id;
                            durum.stk_miktar = stkHareket.stk_miktar;

                            //durum.durum_olcu = stkHareket.stk_olcu;
                            db.StkHareket.Add(stkHareket); // stok hareketi eklendi
                            db.StkDurum.Add(durum);
                            db.SaveChanges();
                            ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", mesaj + " window.location.assign('StokHareketListe.aspx');", true);
                        }

                        //yeni kayıt ve işlem çıkışsa işlemi yaptırma
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Depoda bu malzemeden bulunmadığından çıkış yapılamaz!')", true);
                        }
                    }
                }
                db.SaveChanges();
                // Response.Redirect("StokHareketListe.aspx");

            }
        }

        protected void drpStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(drpStok.SelectedValue))
            {
                product p = stkdb.product.Find(int.Parse(drpStok.SelectedValue));
                var olcu = p.olcu_birimi;
                txtolcubirim.Text = olcu;
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Bilgi", "alert('Ürün seçiniz!')", true);
            }
        }
    }
}