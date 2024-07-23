namespace fiap_5nett_tech.Application.DataTransfer.Request;

public class GetAllContactRequest : ContactRequest
{
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
}