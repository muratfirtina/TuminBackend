using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.UILayoutViewComponents;

public class _TopbarUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}