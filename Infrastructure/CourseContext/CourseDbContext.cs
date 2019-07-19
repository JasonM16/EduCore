using System;
using Domain.CourseAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.CourseContext
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Course> Courses { get; set; }        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>()
                .HasData(SeedData.GetCourseData());
        }
    }
}
