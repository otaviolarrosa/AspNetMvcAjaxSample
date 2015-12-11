using System.Web.Mvc;
using AspNetMvcWithAjaxSample.Models;

namespace AspNetMvcWithAjaxSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        { // Coloque aqui um breakpoint, para verificar se a chamada do seu Ajax está funcionando.
            return Json(new { success = true });
        }


    }
}