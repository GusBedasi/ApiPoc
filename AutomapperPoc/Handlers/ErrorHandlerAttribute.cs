using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AutomapperPoc.Handlers
{
    public class ErrorHandlerAttribute: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            const int statusCode = (int)HttpStatusCode.InternalServerError;
            var exception = context.Exception;

            var response = context.HttpContext.Response;

            response.StatusCode = statusCode;
            response.ContentType = "application/json";
            context.Result = new JsonResult(exception.Message);
        }
    }
}
