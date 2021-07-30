using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PuanEdebiyatTableAdapter dt = new DataSet1TableAdapters.PuanEdebiyatTableAdapter();
            Repeater1.DataSource = dt.puanedebiyat();
            Repeater1.DataBind();
        }
    }
}