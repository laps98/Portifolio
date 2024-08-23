namespace Portifolio.Domain.ViewModel.Cliente;

public sealed class ClienteRequest
{
    public Guid? Id { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Cep { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; }
    public string? Logradouro { get; set; }
    public string? Uf { get; set; }
    public string? Numero { get; set; }
    public string? Observacao { get; set; }
}
