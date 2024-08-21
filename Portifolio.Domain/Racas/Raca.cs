using Portifolio.Domain.Animais;
using Portifolio.Domain.Especies;
using Portifolio.Domain.FichasTecnica;

namespace Portifolio.Domain.Racas;

public class Raca
{
    public Guid Id { get; set; }
    public Guid IdEspecie { get; set; }
    public Guid Descricao { get; set; }

    public virtual Especie Especie { get; set; }
    public virtual ICollection<FichaTecnica> FichasTecnica { get; set; } = new HashSet<FichaTecnica>();
}
