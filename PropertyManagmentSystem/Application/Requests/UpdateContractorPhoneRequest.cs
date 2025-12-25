using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class UpdateContractorPhoneRequest
    {
        public int ContractorId { get; set; }
        public string Phone { get; set; }
    }
}
