using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.BasketContext
{
    class BasketDbContext : DbContext
    {
        public BasketDbContext(DbContextOptions options) : base(options)
        { }



    }
}
