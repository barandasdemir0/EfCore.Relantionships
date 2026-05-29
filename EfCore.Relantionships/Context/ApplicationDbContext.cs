using EfCore.Relantionships.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Relantionships.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInformation> UserInformations { get; set; }


}
