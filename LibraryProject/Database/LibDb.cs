using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.DataClasses;

namespace LibraryProject.Database
{
    public class LibDb : DbContext
    {
        private static bool databaseCreated = false;
        public LibDb()
        {
            if (!databaseCreated)
            {
             //   Database.EnsureDeleted();
                this.Database.EnsureCreated();
                databaseCreated = true;
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(@"Data Source=LibraryDatabase.db");
    }
}
