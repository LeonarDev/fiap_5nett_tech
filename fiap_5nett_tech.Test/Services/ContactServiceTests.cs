using Moq;
using fiap_5nett_tech.Application.Service;
using fiap_5nett_tech.Domain.Repositories;
using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Domain.Entities;
namespace fiap_5nett_tech.Test.Services;
public class ContactServiceTests
{
    private readonly Mock<IContactRepository> _mockContactRepository;
    private readonly Mock<IRegionRepository> _mockRegionRepository;
    private readonly ContactService _contactService;

    public ContactServiceTests()
    {
        _mockContactRepository = new Mock<IContactRepository>();
        _mockRegionRepository = new Mock<IRegionRepository>();
        _contactService = new ContactService(_mockContactRepository.Object, _mockRegionRepository.Object);
    }

    [Fact]
    public void Create_ShouldReturnContactResponse_WhenContactIsCreatedSuccessfully()
    {
        // Arrange
        var request = new ContactRequest
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123456789",
            Ddd = 11
        };

        var region = new Region { Ddd = 11, Name = "São Paulo" };
        _mockRegionRepository.Setup(r => r.GetOne(request.Ddd)).Returns(region);
        _mockContactRepository.Setup(c => c.GetOne(request.Ddd, request.PhoneNumber)).Returns((Contact)null);

        // Act
        var response = _contactService.Create(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(201, response.Code);
        Assert.Equal("Contato criado com sucesso!", response.Message);
        Assert.NotNull(response.Data);
        _mockContactRepository.Verify(c => c.Create(It.IsAny<Contact>()), Times.Once);
    }

    [Fact]
    public void Create_ShouldReturnBadRequest_WhenRegionNotFound()
    {
        // Arrange
        var request = new ContactRequest
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123456789",
            Ddd = 11
        };

        _mockRegionRepository.Setup(r => r.GetOne(request.Ddd)).Returns((Region)null);

        // Act
        var response = _contactService.Create(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(400, response.Code);
        Assert.Equal("Região não encontrada!", response.Message);
        Assert.Null(response.Data);
        _mockContactRepository.Verify(c => c.Create(It.IsAny<Contact>()), Times.Never);
    }

    [Fact]
    public void Create_ShouldReturnBadRequest_WhenPhoneNumberAlreadyExists()
    {
        // Arrange
        var request = new ContactRequest
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123456789",
            Ddd = 11
        };

        var existingContact = new Contact("Jane Doe", "jane.doe@example.com", "123456789", new Region { Ddd = 11 });
        _mockRegionRepository.Setup(r => r.GetOne(request.Ddd)).Returns(new Region { Ddd = 11, Name = "São Paulo" });
        _mockContactRepository.Setup(c => c.GetOne(request.Ddd, request.PhoneNumber)).Returns(existingContact);

        // Act
        var response = _contactService.Create(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(400, response.Code);
        Assert.Equal("Telefone já Cadastrado!", response.Message);
        Assert.Null(response.Data);
        _mockContactRepository.Verify(c => c.Create(It.IsAny<Contact>()), Times.Never);
    }

    [Fact]
    public void Create_ShouldReturnBadRequest_WhenPhoneNumberIsInvalid()
    {
        // Arrange
        var request = new ContactRequest
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "12345",
            Ddd = 11
        };

        _mockRegionRepository.Setup(r => r.GetOne(request.Ddd)).Returns(new Region { Ddd = 11, Name = "São Paulo" });

        // Act
        var response = _contactService.Create(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(400, response.Code);
        Assert.Equal("Quantidade de caracteres de telefone invalido!", response.Message);
        Assert.Null(response.Data);
        _mockContactRepository.Verify(c => c.Create(It.IsAny<Contact>()), Times.Never);
    }
}
