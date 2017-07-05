using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplications.Domain
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double RetailPrice { get; set; }
        public string OptionPackage { get; set; }


        public Car()
        {
            Make = "Undefined";
            Model = "T3 GT";
            Year = 2014;
            Color = "Gray";
            RetailPrice = 70000.0;
            OptionPackage = "Offroad Package";
        }

        //Overloaded constructor
        public Car(string make, string model, int year, string color) : this()
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public Car(string optionsPackage) : this()
        {
           
            //this.Make = "Tesla Motors";
            //this.Model = "T3 GT";
            //this.Year = 2017;
            //this.Color = "Dark Blue";
            //this.OptionPackage = optoionsPackage;

            if (optionsPackage == "Offroad Package")
                RetailPrice = 75000.0;
            else if (optionsPackage == "Sport Package")
                RetailPrice = 80000.0;
            else if (optionsPackage == "Touring Package")
                RetailPrice = 85000.0;                               
        }

        public Car(string optionsPackage, string color) : this(optionsPackage)
        {
            /*
             Make = "Tesla Motors";
            Model = "T3 GT";
            Year = 2017;
            Color = "Dark Blue";
            OptionPackage = optionsPackage;
             */

            /*
              if (optionsPackage == "Offroad Package")
                RetailPrice = 75000.0;
            else if (optionsPackage == "Sport Package")
                RetailPrice = 80000.0;
            else if (optionsPackage == "Touring Package")
                RetailPrice = 85000.0;
             */

            if (color != "Black" && color != "White")
            {
                this.Color = "Custom";
                RetailPrice += 20000.0;
            }
        }

        public string FormatDetailsForDisplay()
        {
            return string.Format("Make: {0} - Model: {1} -  Year: {2} - Color: {3}", Make, Model, Year.ToString(), Color );
        }
    }
}