using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.Sample.Controllers
{
    public class HomeController : AbpController
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public ActionResult Index()
        {
            if (_environment.IsProduction())
            {
                return new ContentResult
                {
                    Content = "服务已经启动"
                };
            }

            return Redirect("~/swagger");
        }
    }
}
