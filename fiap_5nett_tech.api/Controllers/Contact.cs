using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace fiap_5nett_tech.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class Contact : ControllerBase
    {
        private readonly IContactInterface _contactInterface;
        public Contact(IContactInterface contactInterface)
        {
            _contactInterface = contactInterface;
        }

        [HttpPost]
        public void Create([FromBody] ContactRequest contactRequest)
        {
            _contactInterface.Create(contactRequest);
        }

        [HttpPut]
        public void Update([FromBody] ContactRequest contactRequest)
        {
            _contactInterface.Update(contactRequest);
        }

        [HttpGet]
        [Route("{id}")]
        public ContactResponse GetOne([FromRoute] int id)
        {
            return _contactInterface.GetOne(id);
             

        }

        [HttpGet]
        public List<ContactResponse> GetAll([FromQuery] ContactRequest request)
        {
            return _contactInterface.GetAll(request);
        }

    }
}
