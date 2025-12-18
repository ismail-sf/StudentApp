using Crud_app_mvc_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud_app_mvc_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

    }
}
