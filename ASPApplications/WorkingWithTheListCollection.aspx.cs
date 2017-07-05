using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class WorkingWithTheListCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Domain.Car car1 = new Domain.Car("BMW", "528i", 2016, "Black");
            Domain.Car car2 = new Domain.Car("BMW", "745i", 2017, "White");
            Domain.Car car3 = new Domain.Car("VW", "Jetta", 2013, "Red");

            List<Domain.Car> cars = new List<Domain.Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            //Filter set of data:

            //List<Domain.Car> whiteCars = new List<Domain.Car>();
            //whiteCars = cars.FindAll(p => p.Color == "White");
            //for (int i = 0; i < whiteCars.Count; i++)
            //{
            //    result += whiteCars.ElementAt(i).FormatDetailsForDisplay();
            //}

            //cars.ForEach(p => p.Color = "Silver");
            if (cars.Exists(p => p.Year == 2016))
            {
                result += "We do have a 2016 in stock";
            }

            //for (int i = 0; i < cars.Count; i++)
            //{
            //    result += cars.ElementAt(i).FormatDetailsForDisplay();
            //}

            resultLabel.Text = result;
        }
    }
}