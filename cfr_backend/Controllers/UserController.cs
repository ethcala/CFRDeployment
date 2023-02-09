using Microsoft.AspNetCore.Mvc;
using CFRDal;

namespace cfr_backend.Controllers
{
    public class UserController : Controller
    {
        private readonly IManager _dal;
        public UserController(IManager dal)
        {
            _dal = dal;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser()
        {
            return View();
        }
    }
}
