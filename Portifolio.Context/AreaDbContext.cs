using Microsoft.EntityFrameworkCore;
using Portifolio.Domain.Clientes;
using Portifolio.Domain.Context;

namespace Portifolio.Context;

public class AreaDbContext : DbContext, IAreaDbContext
{
    public AreaDbContext(DbContextOptions<AreaDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}

