using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SalesCome.API.Result
{
    public class CreateResult : IActionResult
    {
        private readonly CreateContent _content = new CreateContent();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data"></param>
        public CreateResult(object data)
        {
            _content.data = data;
        }

        /// <summary>
        /// Execute Result method
        /// </summary>
        /// <param name="context"></param>
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(_content.data)
            {
                StatusCode = StatusCodes.Status201Created
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }

    /// <summary>
    /// Class for <see cref="CreationContent"/>
    /// </summary>
    public class CreateContent
    {
        /// <summary>
        /// Value Data
        /// </summary>
        public object data { get; set; }
    }
}
