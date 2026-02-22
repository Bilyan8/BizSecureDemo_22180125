using Microsoft.EntityFrameworkCore;
using BizSecureDemo_22180125.Models;
namespace BizSecureDemo_22180125.Data;
public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users => Set<AppUser>();
    public DbSet<Order> Orders => Set<Order>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
