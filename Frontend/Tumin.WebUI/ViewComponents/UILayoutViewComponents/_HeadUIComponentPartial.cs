using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.ViewComponents.UILayoutViewComponents;

public class _HeadUIComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}