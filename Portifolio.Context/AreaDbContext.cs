using Microsoft.EntityFrameworkCore;
using Portifolio.Domain.Clientes;
using Portifolio.Domain.Context;
using System.Reflection;

namespace Portifolio.Context;

public class AreaDbContext : DbContext, IAreaDbContext
{
    public AreaDbContext(DbContextOptions<AreaDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.RemovePluralizingTableNameConvention();
    }
}

