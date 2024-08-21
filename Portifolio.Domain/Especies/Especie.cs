using Portifolio.Domain.Racas;

namespace Portifolio.Domain.Especies;

public class Especie
{
    public Guid Id { get; set; }
    public Guid Descricao { get; set; }

    public virtual ICollection<Raca> Racas { get; set; } = new HashSet<Raca>();
}
