using GIC_G2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIC_G2.DataContext
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options)
          : base(options)
        {
        }
        public DbSet<Employee> EmployeeTable { get; set; }
    }
}
