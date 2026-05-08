using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default
{
    public class _DefaultNewsletterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
