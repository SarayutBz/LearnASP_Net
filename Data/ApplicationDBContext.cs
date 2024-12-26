using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDBContext:DbContext
    {
     public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { 
        
        }
        public DbSet<Student> Students { get; set; }

    }
}
