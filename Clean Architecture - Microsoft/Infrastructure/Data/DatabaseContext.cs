using Core.Entities;
using Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Datas;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new EntityTypeConfiguration().Configure(modelBuilder.Entity<EntityType>());
    }
}