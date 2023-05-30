using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
