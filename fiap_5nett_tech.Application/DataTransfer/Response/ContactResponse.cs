using System.Text.Json.Serialization;
using fiap_5nett_tech.Domain.Entities;

namespace fiap_5nett_tech.Application.DataTransfer.Response
{
    public class ContactResponse<TData>
    {
        private readonly int _code;
        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    
        [JsonConstructor]
        public ContactResponse() =>  _code = Configuration.DefaultStatusCode;

        public ContactResponse(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            _code = code;
            Data = data;
            Message = message;
        }
    }
}
