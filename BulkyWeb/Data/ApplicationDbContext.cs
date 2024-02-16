using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;
namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        //Creating a table from model category
        public DbSet<Category> Categories { get; set; }

        
    }
}
