using Microsoft.EntityFrameworkCore;
using webIntroHW.Entities;

namespace webIntroHW.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Shipper> Shippers { get; set; }
}
