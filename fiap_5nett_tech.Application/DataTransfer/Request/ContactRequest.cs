using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiap_5nett_tech.Application.DataTransfer.Request
{
    public class ContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }       
        public int DDD { get; set; }

    }
}
