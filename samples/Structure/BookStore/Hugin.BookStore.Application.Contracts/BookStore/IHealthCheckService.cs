using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hugin.BookStore
{
    public interface IHealthCheckService
    {
        Task<IActionResult> HeathCheck();

        Task<IActionResult> Authorize();
    }
}
