

using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace fiap_5nett_tech.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Contact :ControllerBase
    {
        private readonly ContactInterface _contactInterface;
        public Contact(ContactInterface contactInterface)
        {
            _contactInterface = contactInterface;
        }

        [HttpPost]
        public void create([FromBody] ContactRequest contactRequest)
        {
            _contactInterface.create(contactRequest);
        }

    }
}
