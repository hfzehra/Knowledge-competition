using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=UYSAL\SQLEXPRESS; Initial Catalog=BilgiYarisma; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtKayit_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Kaydol.aspx");
        }

        protected void TxtGiris_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("Select * from KullaniciKayit Where OyuncuAdi='" + TxtKullanici.Text + "' and Sifre='" + TxtSifre.Text + "'", baglanti);
            SqlDataReader ds = cmd.ExecuteReader();
            if (ds.Read())
            {
                Session["OyuncuAdi"] = ds["OyuncuAdi"].ToString();
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("Hatalı oyuncu adı veya şifre girdiniz. Lütfen bilgilerinizi kontrol edin");
            }
            baglanti.Close();
        }
    }
}