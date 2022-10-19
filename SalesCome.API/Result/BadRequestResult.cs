using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SalesCome.API.Result
{
    public class BadRequestResult : IActionResult
    {
        public readonly Error error = new Error();

        public BadRequestResult(string _code, string _message)
        {
            error.Code = _code;
            error.Message = _message;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            BadRequest _errorContent = new BadRequest()
            {
                Error = error
            };

            var objectResult = new ObjectResult(_errorContent)
            {
                StatusCode = StatusCodes.Status400BadRequest
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }

    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public class BadRequest
    {
        public Error Error { get; set; }
    }
}
