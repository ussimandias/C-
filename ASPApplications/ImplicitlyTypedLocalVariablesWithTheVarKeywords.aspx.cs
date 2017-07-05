using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ImplicitlyTypedLocalVariablesWithTheVarKeywords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

           var cars = new List<Domain.Car>()
            {
            new Domain.Car { Make = "Mazda", Model = "Mazda3", Year = 2016, Color = "Red" + "</br>" },
            new Domain.Car { Make = "BMW", Model = "745i", Year = 2017, Color = "White" + "</br>" },
            new Domain.Car { Make = "VW", Model = "Jetta", Year = 2013, Color = "Red" + "</br>" },
            new Domain.Car { Make = "Mazda", Model = "Mazda5", Year = 2015, Color = "Blue" }
            };

            //var heroName = "Baltek";


            foreach (Domain.Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }

            resultLabel.Text = result;
        }
    }
}