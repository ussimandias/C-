using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplications.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Room Room { get; set; }
        public  List<Student> Students { get; set; }
        public Schedule[] Schedule { get; set; }

    }
}