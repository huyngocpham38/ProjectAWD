using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WADproject.Models;

namespace WADproject.Models
{
    public class WADprojectContext : DbContext
    {
        public WADprojectContext (DbContextOptions<WADprojectContext> options)
            : base(options)
        {
        }

        public DbSet<WADproject.Models.Category> Category { get; set; }

        public DbSet<WADproject.Models.Product> Product { get; set; }
    }
}
