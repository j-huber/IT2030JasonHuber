﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentID { get; set; }
        public virtual int StudentID { get; set; }
        public virtual int CourseID { get; set; }
        public virtual char Grade{ get; set; }
        public virtual Student Student{ get; set; }
        public virtual Course Course { get; set; }
    }
}