using OrganizerApp;
using System.Data.Entity;
using System.Linq;
using System;
using System.Windows;
using System.Diagnostics;
using OrganizerApp.Entities;

namespace OrganizerApp
{
    public class OrganizerDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public OrganizerDbContext() : base("name=OrganizerDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        
    }
}
