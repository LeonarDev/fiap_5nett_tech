using System.ComponentModel.DataAnnotations;

namespace fiap_5nett_tech.Domain.Entities;

public class Contact
{
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Nome é obrigatório.")]
    [MaxLength(ErrorMessage = "O Nome deve contar até 80 caracteres")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "Formato de email inválido.")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Telefone é obrigatório.")]
    [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Formato de telefone inválido.")]
    public string Phone { get; set; }
    
    public int Region { get; set; }

    public Contact(string name, string email, string phone, int region)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Region = region;
    }

    public Contact()
    {
    }
}