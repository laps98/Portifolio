using Microsoft.EntityFrameworkCore;
using Portifolio.Domain.Clientes;

namespace Portifolio.Domain.Context;

public interface IAreaDbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    int SaveChanges();
    //Task<int> SaveChangesAsync();
}
