using Microsoft.EntityFrameworkCore;
namespace TeachApi.Models
{
    public class ApiContext:DbContext
    {
        public DbSet<Card> Cards {get;set;}
        public DbSet<Document> Documents {get;set;}
        public DbSet<Event> Events {get;set;}
        public DbSet<User> Users {get;set;}  
        public DbSet<Photo> Photos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TeacherDb;Username=pdev;Password=password");
        }      
    }

}