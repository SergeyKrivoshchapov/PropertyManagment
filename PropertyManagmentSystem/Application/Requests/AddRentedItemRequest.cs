using PropertyManagmentSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class AddRentedItemRequest
    {
        public int AgreementId { get; set; }
        public int RoomId { get; set; }
        public RoomPurpose Purpose { get; set; }
        public DateTime RentUntil { get; set; }
        public decimal RentAmount { get; set; }
    }
}
