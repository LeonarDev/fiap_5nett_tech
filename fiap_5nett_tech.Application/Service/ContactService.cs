using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Domain.Repositories;

namespace fiap_5nett_tech.Application.Service
{
    public class ContactService : IContactInterface    {
        
        private readonly IContactRepository _repository;
                
        public ContactService( IContactRepository repository)
        {            
            _repository = repository;            
        }
        public void Create(ContactRequest request)
        {
            var region = new Region(request.Ddd, "teste");
            
            Contact contact = new(request.Name, request.Email, request.PhoneNumber, region);
            _repository.Create(contact);
        }



        //public async Task Create(ContactRequest request)
        //{
        //    Contact contact = new(request.Name, request.Email, request.PhoneNumber, request.DDD);
        //    _context.Contacts.Add(contact);
        //    await _context.SaveChangesAsync();
        //}

        public void Update(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public ContactResponse GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactResponse> GetAll(ContactRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
