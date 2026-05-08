using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
