using Domain.CampusAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CurrentSemesterCourseAggregate
{
    public class MeetingTime
    {
        public int MeetingTimeId { get; set; }
        public int CourseId { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom Room { get; set; }
        public DayOfWeek Day { get; set; }
        public DateTime ClassStartTime { get; set; }
        public DateTime ClassEndTime { get; set; }
    }
}
