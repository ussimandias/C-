using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DevSheet9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myCar = new Car();
            myCar.Make = "Mazda";
            myCar.Model = "Mazda3 S Grand Touring";
            myCar.Year = 2016;
            myCar.Color = "Metallic Blue";

            //double markerValueOfCar = determineMarketValue(myCar);
            double markerValueOfCar = myCar.DetermineMarketValue();

            resultLabel.Text = string.Format("{0} - {1} - {2} - {3} - {4:C} ", myCar.Make, myCar.Model, myCar.Year.ToString(), myCar.Color, markerValueOfCar);  
                       
        }
        //Helper method:
        //private double determineMarketValue(Car car)
        //{
        //    double carValue;
        //    // Someday write code to go online and look uo the car's value and 
        //    // retrieve its value in the carValue variable
        //    if (car.Year > 2006)
        //    {
        //        carValue = 10000.0;
        //    }
        //    else
        //    {
        //            carValue = 20000.0;
        //    }
        //    return carValue;
        //}
             
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue;
            // Someday write code to go online and look uo the car's value and 
            // retrieve its value in the carValue variable
            if (this.Year > 2006)
                carValue = 10000.0;
            else
                carValue = 20000.0;
            return carValue;
        }

    }
}