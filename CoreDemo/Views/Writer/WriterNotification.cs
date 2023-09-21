using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Views.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
