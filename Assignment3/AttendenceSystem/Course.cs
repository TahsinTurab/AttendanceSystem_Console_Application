﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceSystem
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Fees { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }
        public List<CourseStudent> Students { get; set; }
        public List<CourseTeacher> Teachers { get; set; }
    }
}
