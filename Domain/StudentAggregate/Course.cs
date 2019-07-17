using Domain.CurrentSemesterCourseAggregate;
using System.Collections.Generic;

namespace Domain.StudentAggregate
{
    public class Course
    {
        public int CourseId { get; set; }
        public int ProfessorId { get; set; }

        public ICollection<MeetingTime> MeetingTimes { get; } = new HashSet<MeetingTime>();
    }
}
