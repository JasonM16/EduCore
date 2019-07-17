using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CourseContext
{
    class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions options) : base(options)
        { }



    }
}
