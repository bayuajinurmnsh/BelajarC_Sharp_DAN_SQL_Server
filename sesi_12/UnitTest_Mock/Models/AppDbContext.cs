using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace UnitTest_Mock.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<EmployeeItem> Employee { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}
