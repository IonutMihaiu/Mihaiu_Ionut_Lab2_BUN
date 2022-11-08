using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihaiu_Ionut_Lab2.Models;

namespace Mihaiu_Ionut_Lab2.Data
{
    public class Mihaiu_Ionut_Lab2Context : DbContext
    {
        public Mihaiu_Ionut_Lab2Context (DbContextOptions<Mihaiu_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mihaiu_Ionut_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Mihaiu_Ionut_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Mihaiu_Ionut_Lab2.Models.Author> Author { get; set; }

        public DbSet<Mihaiu_Ionut_Lab2.Models.Category> Category { get; set; }
    }
}
