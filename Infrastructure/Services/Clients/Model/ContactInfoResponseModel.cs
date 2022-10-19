namespace SalesCome.Infrastructure.Services.Clients.Model
{
    public class ContactInfoResponseModel
    {
        public long ContactId { get; set; }
        public bool Active { get; set; }
        public int ContactTypeId { get; set; }
        public string ContactType { get; set; }
        public string Informaction { get; set; }
        public long ClientId { get; set; }
    }
}
