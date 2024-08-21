using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Domain.FichasTecnica;

namespace Portifolio.Context.FichasTecnica;

internal class FichaTecnicaTypeConfiguration : IEntityTypeConfiguration<FichaTecnica>
{
    public void Configure(EntityTypeBuilder<FichaTecnica> builder)
    {
        builder.HasKey(q => q.IdAnimal);

        builder.HasOne(q => q.Raca).WithMany(q => q.FichasTecnica).HasForeignKey(q => q.IdRaca);

        builder.HasOne(q => q.Animal)
            .WithOne(q => q.FichaTecnica)
            .HasForeignKey<FichaTecnica>(q => q.IdAnimal);
    }
}
