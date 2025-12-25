using PropertyManagmentSystem.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyManagmentSystem.Application.DTOs;

namespace PropertyManagmentSystem.Application.Requests
{
    public class CreateIndividualContractorRequest
    {
        public string Phone { get; set; }
        public string FullName { get; set; }
        public PassportDataDto Passport { get; set; }
    }
}
