using Microsoft.EntityFrameworkCore;

namespace task_02.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<student> students { get; set; }
    }
}
