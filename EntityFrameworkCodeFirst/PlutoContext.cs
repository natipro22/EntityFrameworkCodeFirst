using DataSource.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkCodeFirst
{
    class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }

        public PlutoContext(): base("name=DefaultConnection")
        {

        }
    }
}
