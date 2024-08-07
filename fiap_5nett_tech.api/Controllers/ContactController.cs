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

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult Create([FromBody] ContactRequest contactRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        var response = _contactInterface.Create(contactRequest);
        
        return response.IsSuccess ? StatusCode(response.Code) : StatusCode(response.Code, response);
    }

    [HttpPut]
    public IActionResult Update([FromBody] ContactRequest contactRequest)
    {
        var response = _contactInterface.Update(contactRequest);
        
        return response.IsSuccess ? StatusCode(response.Code) : StatusCode(response.Code, response);
    }

    [HttpGet]
    [Route("{id:guid}")]
    public ContactResponse<Contact?> GetOne([FromRoute] Guid id)
    {
        return _contactInterface.GetOne(id);
    }
    
    [HttpGet]
    [Route("{ddd:int}/{telefone}")]
    public ContactResponse<Contact?> GetOne([FromRoute] int ddd, [FromRoute] string telefone)
    {
        return _contactInterface.GetOne(ddd, telefone);
    }

    [HttpGet]
    public PagedContactResponse<List<Contact>?> GetAll([FromQuery] GetAllContactRequest contactRequest)
    {
        return _contactInterface.GetAll(contactRequest);
    }
}