using Portifolio.Domain.FichasTecnica;

namespace Portifolio.Domain.Animais;

public class Animal
{
    public Guid Id { get; set; }
    public Guid IdCliente { get; set; }
    public DateTime DataDeRegistro { get; set; }

    public virtual FichaTecnica FichaTecnica{ get; set; }
}
