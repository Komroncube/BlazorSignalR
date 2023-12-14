using BlazorSignalR.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSignalR.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.Migrate();
    }
    public DbSet<User> Users { get; set; }
}
