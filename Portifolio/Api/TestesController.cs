using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("Save")]
    public IActionResult Save(ClienteRequest request)
    {
        var cliente = new Cliente
        {
            //Id = request.Id,
            Nome = request.Nome,
            Telefone = request.Telefone,
            Email = request.Email,
            DataDeRegistro = request.DataDeRegistro,
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
}
