using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AlertMessage("Hello, this is an example of Aert Message !");
    }

    public void AlertMessage(string message)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), " alert('" + message + "');", true);
    }
}