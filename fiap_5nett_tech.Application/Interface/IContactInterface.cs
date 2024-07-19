using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.DataTransfer.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiap_5nett_tech.Application.Interface
{
    public interface IContactInterface
    {
        void Create(ContactRequest request);
        ContactResponse GetOne(int id);
        void Update(ContactRequest request);
        List<ContactResponse> GetAll(ContactRequest request);
        List<ContactResponse> GetAllByDdd(ContactRequest request);

    }
}
