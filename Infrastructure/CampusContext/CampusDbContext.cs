using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CampusContext
{
    class CampusDbContext : DbContext
    {
        public CampusDbContext(DbContextOptions options) : base(options)
        { }



    }
}
