using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();

            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Almanya", City = "Berlin", Place = "Berlin Kapısı" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Fransa", City = "Paris", Place = "Eyfel" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "İtalya", City = "Venedik", Place = "Gondol" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "İtalya", City = "Roma", Place = "Kolezyum" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Çek Cumhuriyeti", City = "Prag", Place = "Meydan" });

            var iterator = visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.Country + " " + iterator.CurrentItem.City + " " + iterator.CurrentItem.Place);
            }

            ViewBag.VisitRoute = strings;

            return View();
        }
    }
}
