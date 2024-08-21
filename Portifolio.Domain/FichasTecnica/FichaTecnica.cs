using Portifolio.Domain.Animais;
using Portifolio.Domain.Enums;
using Portifolio.Domain.Racas;

namespace Portifolio.Domain.FichasTecnica;

public class FichaTecnica
{
    public Guid IdAnimal { get; set; }
    public Guid IdRaca { get; set; }
    public DateTime DataDeCadastro { get; set; }
    public decimal Peso { get; set; }
    public string Cor { get; set; }
    public Sexo Sexo { get; set; }
    public DateTime DataDeAlteracao { get; set; }

    public virtual Animal Animal { get; set; }
    public virtual Raca Raca { get; set; }

}
