using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPApplications.Domain;

namespace ASPApplications
{
    public partial class CreatingConstructorMethods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Domain.Car myCar = new Domain.Car();

            Domain.Car myCar = new Domain.Car();
            printDetails(myCar);

            Domain.Car myCar2 = new Domain.Car("Sport Package");
            printDetails(myCar2);


            Domain.Car myCar3 = new Domain.Car("Sport Package", "Black");
            printDetails(myCar3);

            //resultLabel.Text = myCar.FormatDetailsForDisplay();

        }
        private void printDetails(Domain.Car car)
        {
            resultLabel.Text += string.Format("<p>{0} {1} {2} {3} {4:C}",car.Make, car.Model, car.Year, car.Color, car.RetailPrice);
        }
    }
}