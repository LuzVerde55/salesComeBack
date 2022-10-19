namespace SalesCome.Application.Services.Clients.Model
{
    /// <summary>
    /// Object response contact info
    /// </summary>
    public class ResponseContactInfoModel
    {
        /// <summary>
        /// Contact id
        /// </summary>
        public long ContactId { get; set; }
        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Contact type Id
        /// </summary>
        public int ContactTypeId { get; set; }
        /// <summary>
        /// Contact type name
        /// </summary>
        public string ContactType { get; set; }
        /// <summary>
        /// Informaction result
        /// </summary>
        public string Informaction { get; set; }
        /// <summary>
        /// Client Id Asoc
        /// </summary>
        public long ClientId { get; set; }
    }
}
