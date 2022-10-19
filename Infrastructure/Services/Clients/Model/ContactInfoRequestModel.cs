using System;
using System.Collections.Generic;
using System.Text;

namespace SalesCome.Infrastructure.Services.Clients.Model
{
    public class ContactInfoRequestModel
    {
        public long ContactInfoId { get; set; }
        public int ContactTypeId { get; set; }
        public string Information { get; set; }
        public bool Active { get; set; }
        public int UserCreate { get; set; }
        public long ClientId { get; set; }
    }
}
