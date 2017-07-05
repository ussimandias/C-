using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplications
{
    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int DaysOnTheLot { get; set; }
        public int CarlotParkingSpace { get; set; }
        public double MarketValue { get; set; }
        public double Price { get; set; }
       

        public void DetermineMarketValue() { } 
    }
}