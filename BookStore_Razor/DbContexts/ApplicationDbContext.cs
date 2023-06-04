using BookStore_Razor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookStore_Razor.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
