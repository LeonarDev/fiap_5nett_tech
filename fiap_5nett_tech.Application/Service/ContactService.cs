using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Domain.Repositories;

namespace fiap_5nett_tech.Application.Service
{
    public class ContactService : IContactInterface    {
        
        private readonly IContactRepository _repository;
        private readonly IRegionRepository _region;
                
        public ContactService( IContactRepository repository, IRegionRepository region)
        {            
            _repository = repository;
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

        public List<ContactResponse> GetAllByDdd(ContactRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
