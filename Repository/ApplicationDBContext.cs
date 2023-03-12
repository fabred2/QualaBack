using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Monedas> Monedas { get; set;  }
        public DbSet<Sucursales> Sucursales { get; set;  }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}
