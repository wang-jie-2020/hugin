using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LG.NetCore.Infrastructure.Attributes
{
    /// <summary>
    /// aop-log
    /// 标注API记录输入、输出
    /// 示例：[TypeFilter(typeof(LogApiAttribute))] 或 [ServiceFilter(typeof(LogApiAttribute))]
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class LogApiAttribute : Attribute, IAsyncActionFilter
    {
        private readonly ILogger<LogApiAttribute> _logger;
        private IDictionary<string, object> _data;

        public LogApiAttribute(ILogger<LogApiAttribute> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 记录请求
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            OnActionExecuting(context);
            if (context.Result == null)
            {
                ActionExecutedContext context2 = await next();
                OnActionExecuted(context2);
            }

            WriteLog();
        }

        /// <summary>
        /// 请求前处理记录
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _data = new Dictionary<string, object>();

            try
            {
                _data.Add("requestUser", context.HttpContext.User?.Identity?.Name);
                _data.Add("requestUrl", context.HttpContext.Request.Path.ToString());
                _data.Add("requestMethod", context.HttpContext.Request.Method);
                _data.Add("requestHeaders", context.HttpContext.Request.Headers.ToDictionary(x => x.Key,
                    v => string.Join(";", v.Value.ToList())));
                _data.Add("requestAction", ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).DisplayName);
                _data.Add("requestActionArguments", context.ActionArguments.ToDictionary(x => x.Key,
                    v => JsonConvert.SerializeObject(v.Value)));
                _data.Add("requestQueryString", context.HttpContext.Request.QueryString);
                _data.Add("requestStartAt", DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// 请求后处理记录
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            try
            {
                _data.Add("responseStatus", context.HttpContext.Response.StatusCode);
                _data.Add("responseResult", context.Result);
                _data.Add("responseHeaders", context.HttpContext.Response.Headers.ToDictionary(x => x.Key, v => string.Join(";", v.Value.ToList())));
                _data.Add("responseEndAt", DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                _data.Add("responseException", context.Exception?.Message);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void WriteLog()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (var key in _data.Keys)
                {
                    sb.AppendLine("【" + key + "】：" + JsonConvert.SerializeObject(_data[key]));
                }

                _logger.LogInformation(sb.ToString());
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
