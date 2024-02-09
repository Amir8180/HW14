using Microsoft.AspNetCore.Mvc;

namespace Personels.ViewComponents
{
    public class ModalViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Modal");
        }
    }
}
