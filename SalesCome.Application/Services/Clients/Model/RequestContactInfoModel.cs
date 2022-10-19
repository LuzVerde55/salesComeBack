namespace SalesCome.Application.Services.Clients.Model
{
    /// <summary>
    /// Onject contact info
    /// </summary>
    public class RequestContactInfoModel
    {
        /// <summary>
        /// Contact info id
        /// </summary>
        public long ContactInfoId { get; set; }
        /// <summary>
        /// Contact type Id
        /// </summary>
        public int ContactTypeId { get; set; }
        /// <summary>
        /// Informaction anywhere communication media and address
        /// </summary>
        public string Information { get; set; }
        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// User create 
        /// </summary>
        public int UserCreate { get; set; }
        /// <summary>
        /// Client Id asociated
        /// </summary>
        public long ClientId { get; set; }
    }
}
