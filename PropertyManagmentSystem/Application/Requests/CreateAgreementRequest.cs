using PropertyManagmentSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class CreateAgreementRequest
    {
        public string RegistrationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }
        public int ContractorId { get; set; }
        public decimal PenaltyRate { get; set; }
    }
}
