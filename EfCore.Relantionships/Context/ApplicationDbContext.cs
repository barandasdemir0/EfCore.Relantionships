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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<User>()// ben user tablosuna configurasyon yapacağım diyor
            .HasOne(p => p.UserInformation)//her bir user nesnesi bir tane userınformation nesnesi alır
            .WithOne(p=>p.User)//userinformatinun bir tane userı olabilir
            .HasForeignKey<UserInformation>(p=>p.UserId)//foreign key verme yeri userınformatindaki kolunun adı
            .OnDelete(DeleteBehavior.Cascade); //silme işlemindeki durumu hiç bir şey yapma hata fırlat
    }

}
