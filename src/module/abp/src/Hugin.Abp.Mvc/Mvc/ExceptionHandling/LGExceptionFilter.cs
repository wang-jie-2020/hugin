using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Json;

namespace LG.NetCore.Mvc.ExceptionHandling
{
    public class LGExceptionFilter : AbpExceptionFilter
    {
        private readonly IExceptionToErrorInfoConverter _errorInfoConverter;
        private readonly AbpExceptionHandlingOptions _exceptionHandlingOptions;

        public LGExceptionFilter(IExceptionToErrorInfoConverter errorInfoConverter,
            IHttpExceptionStatusCodeFinder statusCodeFinder,
            IJsonSerializer jsonSerializer,
            IOptions<AbpExceptionHandlingOptions> exceptionHandlingOptions)
            : base(errorInfoConverter, statusCodeFinder, jsonSerializer, exceptionHandlingOptions)
        {
            _errorInfoConverter = errorInfoConverter;
            _exceptionHandlingOptions = exceptionHandlingOptions.Value;
        }

        protected override async Task HandleAndWrapException(ExceptionContext context)
        {
            var remoteServiceErrorInfo = _errorInfoConverter.Convert(context.Exception, _exceptionHandlingOptions.SendExceptionsDetailsToClients);

            var errorResponse = new LGRemoteServiceErrorResponse(context.Exception, remoteServiceErrorInfo);

            await base.HandleAndWrapException(context);

            context.Result = new ObjectResult(errorResponse);
        }
    }
}