using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RegistrarOfficeAggregate.Student
{
    public class StudentRecord : BaseEntity
    {

        public Major Major { get; set; }
        public AcademicStanding AcademicStanding { get; set; }
    }


    public enum AcademicStanding
    {

    }

    public enum Major
    {
    }

}
