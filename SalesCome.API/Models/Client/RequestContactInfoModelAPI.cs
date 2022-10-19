using System.ComponentModel.DataAnnotations;

namespace SalesCome.API.Models.Client 
{ 
    /// <summary>
    /// Onject contact info
    /// </summary>
    public class RequestContactInfoModelAPI
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
        [Required(ErrorMessage = "Value required.")]
        public long ClientId { get; set; }
    }
}
