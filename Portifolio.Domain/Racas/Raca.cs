namespace Portifolio.Domain.Racas;

public class Raca
{
    public Guid Id { get; set; }
    public Guid IdEspecie { get; set; }
    public Guid Descricao { get; set; }

    public Especie Especie { get; set; }
}
