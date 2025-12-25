using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class UpdateAgreementRequest
    {
        public int AgreementId { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? PenaltyRate { get; set; }
    }
}
