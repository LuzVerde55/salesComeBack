using System;
using System.Collections.Generic;

namespace SalesCome.Infrastructure.Services.Clients.Model
{
    public class ClientResponseModel
    {
        public long ClientId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirsSurName { get; set; }
        public string SecondSurName { get; set; }
        public int TypeDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string ShortDocumentName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string UrlImg { get; set; }
        public List<ContactInfoResponseModel> ContactInfoCollection { get; set; }
    }
}
