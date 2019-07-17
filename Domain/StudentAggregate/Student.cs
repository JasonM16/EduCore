using Domain.SharedKernel;
using System;

namespace Domain.StudentAggregate
{
    public class Student : BaseEntity
    {
        public Student(string firstName, string lastName, DateTime dob)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentException("First name.");
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentException("Last name.");
            if (dob.Year > (DateTime.UtcNow.Year - 14)) throw new ArgumentException("Date of Birth."); // students must be 14 to register
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;           
        }
        public int StudentId { get; }
        public string StudentNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        // navigation foreign key - required?
        public int StudentAccountId { get; set; }
        public StudentAccount Account { get; } = new StudentAccount();
    }
}