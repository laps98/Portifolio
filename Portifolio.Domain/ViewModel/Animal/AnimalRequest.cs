using Portifolio.Domain.Enums;

namespace Portifolio.Domain.ViewModel.Animal;

public sealed record AnimalRequest
{
    public Guid Id { get; set; }
    public Guid IdCliente { get; set; }
    public DateTime DataDeRegistro { get; set; }
    public Guid IdRaca { get; set; }
    public DateTime DataDeCadastro { get; set; }
    public decimal Peso { get; set; }
    public string Cor { get; set; }
    public Sexo Sexo { get; set; }
    public DateTime DataDeAlteracao { get; set; }

}
