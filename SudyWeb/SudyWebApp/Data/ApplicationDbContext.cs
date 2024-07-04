using Microsoft.EntityFrameworkCore;
using SudyWebApp.Models;

namespace SudyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {






            
        }

        // this simple one line creates the table , then  we need to do something called migration
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) // thanks to taking ModelBuilder as a parameter, we see the data
        {
            modelBuilder.Entity<Category>().HasData(
             new Category { Id=1, Name="Sude" , DisplayOrder=1},
             new Category  { Id =2, Name = "Ertuğrul" , DisplayOrder = 2},
             new Category { Id = 3, Name = "Goktug" , DisplayOrder = 3}
              ); // whenever u have an update in ur db , u have to add migration
        }





    }
}
