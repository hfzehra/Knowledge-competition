using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class Kaydol : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=UYSAL\SQLEXPRESS; Initial Catalog=BilgiYarisma; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtKaydol_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand cmd=new SqlCommand("Insert into KullaniciKayit (OyuncuAdi,Adınız,Soyadınız,Eposta,Sifre) values ('"+TxtOyuncuAd.Text+ "','" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + TxtEposta.Text + "','" + TxtSifre.Text + "')",baglanti);
            cmd.ExecuteNonQuery();

            Response.Redirect("Login.aspx");
            baglanti.Close();
        }
    }
}