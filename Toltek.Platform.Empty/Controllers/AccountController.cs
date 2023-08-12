using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Toltek.Services;

namespace Toltek.Platform.Empty.Controllers
{
    [Authorize(Roles = "Admin,Reseller,Manager")]
    public class AccountController : TController<AccountController>
    {
        ClientOptions Client;
        public AccountController(WebServices<AccountController> services, ITenancyOptions<ClientOptions> client) : base(services)
        {
            this.Client = client.Value;
        }
        [AllowAnonymous]
        public async Task<IActionResult> LogOut(bool refresh = false)
        {
            if (refresh)
            {
                return await this.SignOut(this.Client.Authority + "/Home/Index");
            }
            return await this.SignOut();
        }
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
