namespace fiap_5nett_tech.Domain.Entities;

public class Contact
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public Region Ddd { get; set; }

    public Contact(string name, string email, string phone, Region ddd)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Ddd = ddd;
    }

    public Contact()
    {
    }
}