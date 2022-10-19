using System;
using System.ComponentModel.DataAnnotations;

namespace SalesCome.API.Models.Client
{
    /// <summary>
    /// Class object client
    /// </summary>
    public class RequestClientModelAPI
    {
        /// <summary>
        /// ClientId
        /// </summary>
        public long ClientId { get; set; }
        /// <summary>
        /// First Name Client
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Second Name Client
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// First SurName Client
        /// </summary>
        public string FirsSurName { get; set; }
        /// <summary>
        /// Second Sur Name Client
        /// </summary>
        public string SecondSurName { get; set; }
        /// <summary>
        /// Type Document Client
        /// </summary>
        public int TypeDocumentId { get; set; }
        /// <summary>
        /// Document Number Client
        /// </summary>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// BirthDate Client
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Imagen Client
        /// </summary>
        public string UrlImg { get; set; }
        /// <summary>
        /// User Create Client
        /// </summary>
        [Required(ErrorMessage = "Value required.")]
        public int UserCreate { get; set; }
    }
}
