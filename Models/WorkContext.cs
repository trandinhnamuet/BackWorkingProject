using Microsoft.EntityFrameworkCore;

namespace WorkingProject.Models
{
    public class WorkContext : DbContext
    {   
        public WorkContext (DbContextOptions<WorkContext> options) : base(options) { }

        public DbSet<Work> Work { get; set; }

    }
}
