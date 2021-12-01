using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Hugin.Web.Pages
{
    public class IndexModel : BasePageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}