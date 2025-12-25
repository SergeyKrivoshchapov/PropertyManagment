using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Requests
{
    public class CreateBuildingRequest
    {
        public string District { get; set; }
        public string Address { get; set; }
        public int FloorsCount { get; set; }
        public string CommandantPhone { get; set; }
    }

}
