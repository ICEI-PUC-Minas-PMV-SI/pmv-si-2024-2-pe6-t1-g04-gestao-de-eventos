using Microsoft.EntityFrameworkCore;

namespace AppDbContext.Models;

public class AppDbContext : DbContext 
{
    public AppDbContext(AppDbContextOptions options) : base(options)
    {        
    }

    public DbSet<Usuario> Usuario { get; set; }
}

