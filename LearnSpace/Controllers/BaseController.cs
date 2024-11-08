using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
