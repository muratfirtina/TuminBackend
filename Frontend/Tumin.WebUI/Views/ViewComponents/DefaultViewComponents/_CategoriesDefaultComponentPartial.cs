using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.DefaultViewComponents;

public class _CategoriesDefaultComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
