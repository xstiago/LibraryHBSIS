using LibraryHBSIS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHBSIS.DataAccess
{
    public class LibraryHBSISContext : DbContext
    {
        public LibraryHBSISContext()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<LibraryHBSISContext, LibraryHBSIS.DataAccess.Migrations.Configuration>("LibraryHBSISContext"));
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
