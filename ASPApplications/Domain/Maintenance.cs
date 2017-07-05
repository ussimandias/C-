using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplications
{
    public class Maintenance
    {
        public bool HasBeenDetailed { get; set; }
        public string DetailedServicedHistory { get; set; }

        public void SendToDetailer() { }
        public void AddToServiceHistory() { }
    }
}