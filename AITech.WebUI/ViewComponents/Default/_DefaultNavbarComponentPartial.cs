using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

