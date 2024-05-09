using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.ProductListViewComponent;

public class _ProductListBrandFilterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}