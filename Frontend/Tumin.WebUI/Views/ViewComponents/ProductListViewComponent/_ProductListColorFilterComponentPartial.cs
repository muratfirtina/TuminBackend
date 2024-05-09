using Microsoft.AspNetCore.Mvc;

namespace Tumin.WebUI.Views.ViewComponents.ProductListViewComponent;

public class _ProductListColorFilterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}