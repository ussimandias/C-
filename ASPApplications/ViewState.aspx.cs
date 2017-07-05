using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class Devsheet4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState.Add("MyValue", "Usman");
                //ViewState.Add("MyValue", "");
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            /*
             * viewstates allows you to preserve page and control values
             * between round-trips to the web server
             */
            string value = ViewState["MyValue"].ToString();
            //resultLabel.Text = value;
            value += serverTextBox.Text + " ";

            ViewState["MyValue"] = value;
            resultLabel.Text = value;

            serverTextBox.Text = "";


        }
    }
}