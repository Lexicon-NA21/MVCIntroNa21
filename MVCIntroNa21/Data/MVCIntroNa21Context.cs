using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCIntroNa21.Models;

namespace MVCIntroNa21.Data
{
    public class MVCIntroNa21Context : DbContext
    {
        public MVCIntroNa21Context (DbContextOptions<MVCIntroNa21Context> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
