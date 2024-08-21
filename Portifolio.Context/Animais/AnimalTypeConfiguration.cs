using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Domain.Animais;

namespace Portifolio.Context.Animais;

internal class AnimalTypeConfiguration : IEntityTypeConfiguration<Animal>
{
    public void Configure(EntityTypeBuilder<Animal> builder)
    {
        builder.HasKey(q => q.Id);

        builder.HasOne(q => q.Cliente).WithMany(q => q.Animais).HasForeignKey(q => q.IdCliente);
    }
}
