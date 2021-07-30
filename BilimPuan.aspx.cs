using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace bilgiyarisma
{
    public partial class WebForm3 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PuanBilim_TableAdapter dt = new DataSet1TableAdapters.PuanBilim_TableAdapter();
            Repeater1.DataSource = dt.Puanbilim();
            Repeater1.DataBind();
        }
    }
}