using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Maria_Smaranda_Lab8.Models;

namespace Rusu_Maria_Smaranda_Lab8.Data
{
    public class Rusu_Maria_Smaranda_Lab8Context : DbContext
    {
        public Rusu_Maria_Smaranda_Lab8Context (DbContextOptions<Rusu_Maria_Smaranda_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Maria_Smaranda_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rusu_Maria_Smaranda_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rusu_Maria_Smaranda_Lab8.Models.Category> Category { get; set; }
    }
}
