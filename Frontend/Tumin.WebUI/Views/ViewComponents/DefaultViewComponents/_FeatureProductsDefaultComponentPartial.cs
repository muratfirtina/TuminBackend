using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.DefaultViewComponents;

public class _FeatureProductsDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}