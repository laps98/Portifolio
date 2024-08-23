using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Portifolio.Domain.Clientes;
using Portifolio.Domain.Context;
using Portifolio.Domain.ViewModel.Cliente;

namespace Portifolio.Api;

[ApiController]
[Route("api/[controller]")]
public class TestesController : Controller
{
    private readonly IAreaDbContext _context;

    public TestesController(IAreaDbContext context)
    {
        _context = context;
    }

    [HttpPost("Save")]
    public IActionResult Save(ClienteRequest request)
    {
        try
        {
            var hoje = DateTime.Now;

            var cliente = new Cliente
            {
                Nome = request.Nome,
                Telefone = request.Telefone,
                Email = request.Email,
                DataDeRegistro = hoje,
                Cep = request.Cep,
                Bairro = request.Bairro,
                Localidade = request.Localidade,
                Logradouro = request.Logradouro,
                Uf = request.Uf,
                Numero = request.Numero,
                Observacao = request.Observacao,
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return Ok("Salvo com sucesso");
        }
        catch (Exception ex)
        {
            // Logar o erro (use um logger configurado)
            // logger.LogError(ex, "Erro ao salvar o cliente");

            // Retornar um erro 500 com uma mensagem detalhada
            return StatusCode(500, "Ocorreu um erro ao salvar o cliente. Por favor, tente novamente.");
        }
    }

}
