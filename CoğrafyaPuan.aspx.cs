using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PuanCoğrafyaTableAdapter dt = new DataSet1TableAdapters.PuanCoğrafyaTableAdapter();
            Repeater1.DataSource = dt.puancoğrafya();
            Repeater1.DataBind();
        }
    }
}