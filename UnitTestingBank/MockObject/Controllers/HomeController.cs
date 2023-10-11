using Microsoft.AspNetCore.Mvc;

namespace MockObject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetDataDatabase _data;

        public HomeController(IGetDataDatabase data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }
    }
}
