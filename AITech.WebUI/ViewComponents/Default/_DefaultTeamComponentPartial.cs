using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default
{
    public class _DefaultTeamComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
