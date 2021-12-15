using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Volo.Abp.Http;

namespace LG.NetCore.Mvc.ResultHandling
{
    /*
     *  因abp的httpClient在设计时未考虑到可能出现的封装，故不再封装
     */
    public class LGResultFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (ShouldHandleResult(context))
            {
                await HandleAndWrapResult(context);
            }

            await next();
        }

        protected virtual bool ShouldHandleResult(ResultExecutingContext context)
        {
            if (context.ActionDescriptor.IsControllerAction() &&
                context.ActionDescriptor.HasObjectResult())
            {
                return true;
            }

            if (context.HttpContext.Request.CanAccept(MimeTypes.Application.Json))
            {
                return true;
            }

            if (context.HttpContext.Request.IsAjax())
            {
                return true;
            }

            return false;
        }

        protected virtual async Task HandleAndWrapResult(ResultExecutingContext context)
        {
            var result = (context.Result as ObjectResult)?.Value;
            if (result != null)
            {
                var response = new LGRemoteServiceSuccessResponse(result);
                context.Result = new ObjectResult(response);

            }
            await Task.CompletedTask;
        }
    }
}
