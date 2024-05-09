using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.UILayoutViewComponents;

public class _ScriptUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}