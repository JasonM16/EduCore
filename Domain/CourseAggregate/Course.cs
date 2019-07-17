using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CourseAggregate
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string DepartmentName { get; set; }
        public string CourseNumber { get; set; }
    }
}