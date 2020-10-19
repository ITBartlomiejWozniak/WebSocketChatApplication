using Microsoft.AspNetCore.Mvc;

namespace WebSocketChatApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
