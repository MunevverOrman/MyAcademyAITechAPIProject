using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default
{
    public class _DefaultFAQComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
