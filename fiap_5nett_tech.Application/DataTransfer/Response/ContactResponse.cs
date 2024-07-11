using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiap_5nett_tech.Application.DataTransfer.Response
{
    public class ContactResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public RegionResponse Region { get; set; }
    }
}
