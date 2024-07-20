using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Domain.Repositories;
using Azure.Core;

namespace fiap_5nett_tech.Application.Service
{
    public class ContactService : IContactInterface    {
        
        private readonly IContactRepository _contact;
        private readonly IRegionRepository _region;
                
        public ContactService( IContactRepository contact, IRegionRepository region)
        {            
            _contact = contact;
            _region = region;
        }
        public void Create(ContactRequest request)
        {
            var region = _region.GetOne(request.Ddd);

            if (region == null)
            {
                //TODO criar as exceptions
                return;
            }
            
            Contact contact = new(request.Name, request.Email, request.PhoneNumber, region);
            _contact.Create(contact);
        }


        public void Update(ContactRequest contactRequest)
        {
            var contact = _contact.GetOne(contactRequest.Ddd, contactRequest.PhoneNumber);

            if (contact == null)
            {
                //TODO criar as exceptions
                return;
            }

            if(!string.IsNullOrEmpty(contactRequest.Name))
            contact.Name = contactRequest.Name;

            if (!string.IsNullOrEmpty(contactRequest.Email))
                contact.Email = contactRequest.Email;

            _contact.Update(contact);
           
        }

        public ContactResponse GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactResponse> GetAll(ContactRequest request)
        {
            //TODO terminar os Services
            throw new NotImplementedException();
        }

        public List<ContactResponse> GetAllByDdd(ContactRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
