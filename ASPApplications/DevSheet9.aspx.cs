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
    /* Class is a code block that defines a data type.
     * ***********************************************
     * An Object is an instance of a Class.
     * Metaphors:
     * Blueprint vs. Houses
     * Recipe vs. Cupcakes
     * Pattern vs. Bluejeans
     * Cookie cutter vs. Cookies
     * 
     * Classes have members, like Properties and Methods.
     * 
     * Properties define the attributes that are set on 
     * an instance of the class / they represent the "state" 
     * of the object at a moment in time inside a application.
     * you  can SET (assign) an GET (retrieve) property values
     *  on an object.
     *  
     *  Methods define actions an instance of a class
     *  can perform, usually on the object instance itself.
     *  
     *  You can create an instance of a class using the new keyword:
     *  Think: 'factory'.
     *  
     *  You can access the members of an object by using
     *  the member access operator, the dot (.)
     *  
     *  Conceptually classes are delegated a responsibily
     *  in the system or represent some domain concept
     *  in the system.
     *  
     *  Classes are ultimately custom data types, more complex 
     *  than the simple data types.
     *  Therefore you can use them anywhere you use other
     *  data types (like as input parameters or return
     *  values from a method.)
     *  
     *  this keyword - Access a member of the 
     *  current instance of the class.
     */
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