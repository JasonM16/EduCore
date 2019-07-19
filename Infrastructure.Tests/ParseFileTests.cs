using Infrastructure.CourseContext;
using Xunit;

namespace Infrastructure.Tests
{
    public class ParseFileTests
    {
        [Fact]
        public void CanLoadCoursesFromFile()
        {
            var result = SeedData.GetCourseData();
            Assert.NotEmpty(result);
        }


    }
}
