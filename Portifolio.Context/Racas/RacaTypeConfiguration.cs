using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Domain.Racas;

namespace Portifolio.Context.Racas;

internal class RacaTypeConfiguration : IEntityTypeConfiguration<Raca>
{
    public void Configure(EntityTypeBuilder<Raca> builder)
    {
        builder.HasKey(q => q.Id);

        builder.HasOne(q => q.Especie).WithMany(q => q.Racas).HasForeignKey(q => q.IdEspecie);
    }
}
