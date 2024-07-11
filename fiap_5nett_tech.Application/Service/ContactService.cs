using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using System;


namespace fiap_5nett_tech.Application.Service
{
    public class ContactService : ContactInterface
    {
        private readonly AppDbContext _context;
        public void create(ContactRequest request)
        {
            Contact contact = new(request.Name, request.Email, request.PhoneNumber, request.DDD);
        }

        public ContactService(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(ContactRequest request)
        {
            Contact contact = new(request.Name, request.Email, request.PhoneNumber, request.DDD);
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
        }
    }
}
