using System.ComponentModel.DataAnnotations;

namespace SalesCome.API.Models.Security
{
    /// <summary>
    /// Model Request API Autentica
    /// </summary>
    public class RequestAutenticaModelAPI
    {
        /// <summary>
        /// User Name
        /// </summary>
        [StringLength(25, ErrorMessage = "The {0} value cannot exceded {1} characters.")]
        public string NickName { get; set; }
        /// <summary>
        /// Password User
        /// </summary>
        [StringLength(25, ErrorMessage = "The {0} value cannot exceded {1} characters.")]
        [MinLength(2, ErrorMessage = "{The {0} value cannot min value {1} characters.")]
        public string CounterSing { get; set; }
    }
}
