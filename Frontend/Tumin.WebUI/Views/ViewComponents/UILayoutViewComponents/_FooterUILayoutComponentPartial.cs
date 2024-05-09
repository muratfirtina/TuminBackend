using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.UILayoutViewComponents;

public class _FooterUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}