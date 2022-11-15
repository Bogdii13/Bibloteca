using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sas_Bogdan_Lab2.Models;

namespace Sas_Bogdan_Lab2.Data
{
    public class Sas_Bogdan_Lab2Context : DbContext
    {
        public Sas_Bogdan_Lab2Context (DbContextOptions<Sas_Bogdan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sas_Bogdan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sas_Bogdan_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Sas_Bogdan_Lab2.Models.Author> Author { get; set; }

        public DbSet<Sas_Bogdan_Lab2.Models.Category> Category { get; set; }

        public DbSet<Sas_Bogdan_Lab2.Models.Borrowing> Borrowing { get; set; }
      
    }
}
