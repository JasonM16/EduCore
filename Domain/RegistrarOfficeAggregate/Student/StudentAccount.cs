using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RegistrarOfficeAggregate.Student
{
    public class StudentAccount
    {
        public int StudentAccountId { get; set; }


        public StudentRecord StudentRecord { get; set; }
        public ContactDetails ContactDetails { get; set; }

    }
}
