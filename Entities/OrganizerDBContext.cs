using Microsoft.EntityFrameworkCore;

namespace OrganizerApp.Entities
{
    public class OrganizerDbContext : DbContext
    {


        public DbSet<User> User { get; set; }
        /*public DbSet<Note> Note { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Categorie> Categorie { get; set; }*/

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DataBase=OrganizerDB;Trusted_Connection=true;");
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrganizerApp.Entities.OrganizerDbContext;Integrated Security=True");
            }
        }
    }
}
