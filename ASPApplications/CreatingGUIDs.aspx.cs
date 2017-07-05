using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class CreatingGUIDs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            http://en.wikipedia.org/wiki/Gobally_unique_identifier

            //var myGuid = Guid.NewGuid();
            //resultLabel.Text = myGuid.ToString();

            //Parsing a string into a Guid
            //var myOtherGuid = Guid.Parse("903FC45E-1AE1-4B54-B566-001BD31E3894");

            Guid myOtherOtherGuid;
            if (Guid.TryParse("B4633B4F-8924-4FF7-AB96-003880E70353", out myOtherOtherGuid))
            {
                resultLabel.Text = myOtherOtherGuid.ToString();
            }
        }
    }
}