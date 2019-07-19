using Domain.CourseAggregate;
using System.Linq;
using Xunit;

namespace Domain.Tests
{
    public class CourseAggregateTests
    {
        [Fact]
        public void Can_Add_Prerequisite_Course_To_Existing_Course()
        {
            // arrange
            var course1 = new Course
            {
                Id = 1,
                CourseName = "Test Course 1",
                CourseNumber = "1234",
                CourseDescription = "Sample Description",
                Credits = 3,
                DepartmentCode = "MATH"
            };


            var course2 = new Course
            {
                Id = 2,
                CourseName = "Test Course 2",
                CourseNumber = "2345",
                CourseDescription = "Sample Description 2",
                Credits = 3,
                DepartmentCode = "MATH"
            };

            
            // act
            course2.PrerequisiteCourses.Add(course1);

            // assert
            Assert.Equal("1234", course2.PrerequisiteCourses.FirstOrDefault().CourseNumber);
        }

    }
}
