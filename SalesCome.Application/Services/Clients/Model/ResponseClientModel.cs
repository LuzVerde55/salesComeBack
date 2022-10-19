using System;
using System.Collections.Generic;

namespace SalesCome.Application.Services.Clients.Model
{
    /// <summary>
    /// Object response client
    /// </summary>
    public class ResponseClientModel
    {
        /// <summary>
        /// Client Id
        /// </summary>
        public long ClientId { get; set; }
        /// <summary>
        /// First Name client
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Second Name Client
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// First Sur Name Client
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
        /// Document Name Client
        /// </summary>
        public string DocumentName { get; set; }
        /// <summary>
        /// Shart Name Document Client
        /// </summary>
        public string ShortDocumentName { get; set; }
        /// <summary>
        /// Document Number Client
        /// </summary>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// BirthDate Client
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Ima Client
        /// </summary>
        public string UrlImg { get; set; }
        /// <summary>
        /// Object contact info client
        /// </summary>
        public List<ResponseContactInfoModel> ContactInfoCollection { get; set; }
    }
}
