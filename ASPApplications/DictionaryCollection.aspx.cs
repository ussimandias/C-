using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DictionaryCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            //Do Stuff

            //Object Initializer:
            /*
            Dictionary<string, Domain.Car> cars = new Dictionary<string, Domain.Car>();
            cars.Add("V1", new Domain.Car { Make = "Mazda", Model = "Mazda3", Year = 2016, Color = "Red" + "</br>" });
            cars.Add("V2", new Domain.Car { Make = "BMW", Model = "745i", Year = 2017, Color = "White" + "</br>" });
            cars.Add("V3", new Domain.Car { Make = "VW", Model = "Jetta", Year = 2013, Color = "Red" + "</br>" });
             */

            //Collection Initializer:
            Dictionary<string, Domain.Car> cars = new Dictionary<string, Domain.Car>(){
                { "V1", new Domain.Car { Make = "Mazda", Model = "Mazda3", Year = 2016, Color = "Red" + "</br>" } },
                { "V2", new Domain.Car { Make = "BMW", Model = "745i", Year = 2017, Color = "White" + "</br>" } },
                { "V3", new Domain.Car { Make = "VW", Model = "Jetta", Year = 2013, Color = "Red" + "</br>" } }
                };

            if (cars.Remove("V1"))
            {
                result += "Successfully removed V1 <br/>";
            }

            for (int i = 0; i < cars.Count; i++)
            {
                result += "<h1>" + cars.ElementAt(i).Key + "</h2>" + cars.ElementAt(i).Value.FormatDetailsForDisplay();
            }


            /*
             Domain.Car v2;
           if (cars.TryGetValue("V2",out v2))
           {
               result += v2.FormatDetailsForDisplay();
           }
           */

            resultLabel.Text = result;
            

        }
    }
}