using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgiyarisma
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PuanSanatTableAdapter dt = new DataSet1TableAdapters.PuanSanatTableAdapter();
            Repeater1.DataSource = dt.puansanat();
            Repeater1.DataBind();

        }
    }
}