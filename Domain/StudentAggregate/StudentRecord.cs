using Domain.SharedKernel;

namespace Domain.StudentAggregate
{
    public class StudentRecord : BaseEntity
    {
        public StudentRecord()
        {
            //PreviousCoursesTaken = new List<StudentSchedule>();
        }
        public int StudentRecordId { get; set; }
        //public Student Student { get; set; }
        public float? GPA { get; set; }
        //public ICollection<StudentSchedule> PreviousCoursesTaken { get; set; }
    }
}