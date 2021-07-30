using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace bilgiyarisma
{
    public partial class Yarisma : System.Web.UI.Page
    {
        SqlConnection data = new SqlConnection(@"Data Source=UYSAL\SQLEXPRESS; Initial Catalog=BilgiYarisma; Integrated Security=True");
        public static int sayac = 0;
        public static int puan = 0;
        public static int zaman = 21;
        protected void Button5_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            zaman = 21;

            sayac++;
            Lblsoru.Text = sayac.ToString();

            Button5.Enabled = false;
            Button5.Text = "SONRAKİ";
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            if (sayac == 1)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim1 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 2)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim2 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 3)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim3 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 4)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim4 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 5)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim5 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 6)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim6 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 7)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim7 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 8)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim8 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 9)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim9 order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else if (sayac == 10)
            {
                data.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilim order by NEWID()", data); //rastegele veri çekme
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Button1.Text = (oku["a"].ToString());
                    Button2.Text = (oku["b"].ToString());
                    Button3.Text = (oku["c"].ToString());
                    Button4.Text = (oku["d"].ToString());

                    TextBox1.Text = (oku["soru"].ToString());

                    Label3.Text = (oku["dogru"].ToString());
                }
                data.Close();
            }
            else
            { 
                
                data.Open();

                SqlCommand cmd = new SqlCommand("Insert into PuanBilim (OyuncuAdı,puan) values ('" + Label5.Text + "','" + Label2.Text + "')", data);
                cmd.ExecuteNonQuery();

                Response.Redirect("BilimPuan.aspx");
                data.Close();
            }
        }
        
        private void aktiflik()
        { 
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = true;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = Session["OyuncuAdi"].ToString();

            Lblsoru.Text = sayac.ToString();
            if (sayac == 0)
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                TextBox1.Text = "BAŞLAMAYA HAZIR MISIN ?";
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
            }
            else
            {
                Label2.Visible = true;
                Label4.Visible = true;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text==Label3.Text)
            {
                puan = puan + 10;
                Label2.Text = puan.ToString();
            }
            else
            {
                puan = puan - 2;
                Label2.Text = puan.ToString();
            }
            aktiflik();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Button2.Text == Label3.Text)
            {
                puan = puan + 10;
                Label2.Text = puan.ToString();
            }
            else
            {
                puan = puan - 2;
                Label2.Text = puan.ToString();
            }
            aktiflik();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.Text == Label3.Text)
            {
                puan = puan + 10;
                Label2.Text = puan.ToString();
            }
            else
            {
                puan = puan - 2;
                Label2.Text = puan.ToString();
            }
            aktiflik();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Button4.Text == Label3.Text)
            {  
                puan = puan + 10;
                Label2.Text = puan.ToString();
            }
            else
            {
                puan = puan - 2;
                Label2.Text = puan.ToString();
            }
            aktiflik();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            Label4.Text = zaman.ToString();
            if (zaman == 0)
            {
                Timer1.Enabled = false;
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = true;
            }
        }
    }
}