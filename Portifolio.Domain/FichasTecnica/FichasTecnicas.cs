namespace Portifolio.Domain.FichasTecnica;

public class FichasTecnicas
{
    public Guid IdAnimal { get; set; }
    public Guid IdRaca { get; set; }
    public DateTime DataDeCadastro { get; set; }
    public Decimal Peso { get; set; }
    public string Cor { get; set; }
    public Sexo Sexo { get; set; }
    public DateTime DataDeAlteracao { get; set; }

}
