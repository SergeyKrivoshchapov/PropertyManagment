using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class UpdateBuildingRequest
    {
        public int BuildingId { get; set; }
        public string District { get; set; }
        public string CommandantPhone { get; set; }
    }
}
