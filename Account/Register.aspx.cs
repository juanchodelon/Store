using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["loged"] = 0;
    }

    protected void Vendedor_Click(object sender, EventArgs e)
    {
        Session["loged"] = 1;
        Response.Redirect("~/");
    }
    protected void Cliente_Click(object sender, EventArgs e)
    {
        Session["loged"] = 2;
        Response.Redirect("~/");
    }
}