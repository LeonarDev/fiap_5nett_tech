using fiap_5nett_tech.Domain.Entities;
using fiap_5nett_tech.Domain.Repositories;
using fiap_5nett_tech.Infrastructure.Data;
using System.Data.Common;

namespace fiap_5nett_tech.Infrastructure.Repositories
{
    public class ContactRepository: IContactRepository
    {
        private readonly AppDbContext _context;
        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }

        public void Update(Contact contact)
        {
            try
            {
                _context.Contacts.Update(contact);
                _context.SaveChanges();
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact GetOne(int id)
        {
            throw new NotImplementedException();
        }               
    }
}
