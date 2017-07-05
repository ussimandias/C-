using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class StaticVsInstance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int myValue = Domain.Valuation.PerformCalculation(2,8);

            /*
            Domain.Valuation myValuation = new Domain.Valuation();
            myValuation.MyProperty = 4;
            */
        }
      
    }
}