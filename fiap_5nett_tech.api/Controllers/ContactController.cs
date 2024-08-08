using System.ComponentModel.DataAnnotations;
using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace fiap_5nett_tech.api.Controllers;

[ApiController]
[Route("api/[controller]/")]
public class ContactController : ControllerBase
{
    private readonly IContactInterface _contactInterface;
    public ContactController(IContactInterface contactInterface)
    {
        _contactInterface = contactInterface;
    }

    /// <summary>
    /// Cria um novo contato.
    /// </summary>
    /// <param name="contactRequest">O objeto de solicitação de criação do contato.</param>
    /// <response code="201">Retorna o novo contato criado.</response>
    /// <response code="400">Solicitação inválida.</response>
    /// <response code="500">Houve um erro interno no servidor.</response>
    /// <returns>Uma resposta de contato recém-criada.</returns>
    [HttpPost]
    public IActionResult Create([FromBody] ContactRequest contactRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        var response = _contactInterface.Create(contactRequest);
        
        return response.IsSuccess ? StatusCode(response.Code) : StatusCode(response.Code, response);
    }

    /// <summary>
    /// Atualiza um contato existente.
    /// </summary>
    /// <param name="contactRequest">O objeto de solicitação de atualização do contato.</param>
    /// <response code="200">Retorna o contato atualizado.</response>
    /// <response code="400">Solicitação inválida.</response>
    /// <response code="500">Houve um erro interno no servidor.</response>
    /// <returns>Uma resposta de contato atualizada.</returns>
    [HttpPut]
    public IActionResult Update([FromBody] ContactRequest contactRequest)
    {
        var response = _contactInterface.Update(contactRequest);
        
        return response.IsSuccess ? StatusCode(response.Code) : StatusCode(response.Code, response);
    }

    /// <summary>
    /// Obtém um contato pelo ID.
    /// </summary>
    /// <param name="id">ID do contato.</param>
    /// <response code="200">Retorna o contato se encontrado.</response>
    /// <response code="404">Se o contato não for encontrado.</response>
    /// <response code="500">Houve um erro interno no servidor.</response>
    /// <returns>Um objeto de resposta de contato.</returns>
    [HttpGet]
    [Route("{id:guid}")]
    public ContactResponse<Contact?> GetOne([FromRoute] Guid id)
    {
        return _contactInterface.GetOne(id);
    }

    /// <summary>
    /// Obtém um contato pelo DDD e número de telefone.
    /// </summary>
    /// <param name="ddd">DDD do contato.</param>
    /// <param name="telefone">Número de telefone do contato.</param>
    /// <response code="200">Retorna o contato se encontrado.</response>
    /// <response code="404">Se o contato não for encontrado.</response>
    /// <response code="500">Houve um erro interno no servidor.</response>
    /// <returns>Um objeto de resposta de contato.</returns>
    [HttpGet]
    [Route("{ddd:int}/{telefone}")]
    public ContactResponse<Contact?> GetOne([FromRoute] int ddd, [FromRoute] string telefone)
    {
        return _contactInterface.GetOne(ddd, telefone);
    }

    /// <summary>
    /// Obtém todos os contatos
    /// </summary>
    /// <param name="contactRequest">O objeto de solicitação para buscar todos os contatos.</param>
    /// <response code="200">Retorna uma lista paginada de contatos.</response>
    /// <response code="400">Solicitação inválida.</response>
    /// <response code="500">Houve um erro interno no servidor.</response>
    /// <returns>Um objeto de resposta de contato paginado.</returns>
    [HttpGet]
    public PagedContactResponse<List<Contact>?> GetAll([FromQuery] GetAllContactRequest contactRequest)
    {
        return _contactInterface.GetAll(contactRequest);
    }
}