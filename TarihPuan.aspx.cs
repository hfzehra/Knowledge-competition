using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PuanTarihTableAdapter dt = new DataSet1TableAdapters.PuanTarihTableAdapter();
            Repeater1.DataSource = dt.puantarih();
            Repeater1.DataBind();
        }
    }
}