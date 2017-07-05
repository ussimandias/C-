﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplications.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}