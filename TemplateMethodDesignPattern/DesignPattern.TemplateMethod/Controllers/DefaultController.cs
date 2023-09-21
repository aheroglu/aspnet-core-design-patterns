using DesignPattern.TemplateMethod.TemplateMethodPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();

            ViewBag.PlanType = netflixPlans.PlanType("Temel Plan");
            ViewBag.PersonCount = netflixPlans.PersonCount(1);
            ViewBag.Price = netflixPlans.Price(65.99);
            ViewBag.Content = netflixPlans.Content("Film-Dizi");
            ViewBag.Resolution = netflixPlans.Resolution("480px");

            return View();
        }

        public IActionResult StandartPlan()
        {
            NetflixPlans netflixPlans = new StandartPlan();

            ViewBag.PlanType = netflixPlans.PlanType("Standart Plan");
            ViewBag.PersonCount = netflixPlans.PersonCount(2);
            ViewBag.Price = netflixPlans.Price(94.99);
            ViewBag.Content = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.Resolution = netflixPlans.Resolution("720px");

            return View();
        }

        public IActionResult UltraPlan()
        {
            NetflixPlans netflixPlans = new UltraPlan();

            ViewBag.PlanType = netflixPlans.PlanType("Ultra Plan");
            ViewBag.PersonCount = netflixPlans.PersonCount(4);
            ViewBag.Price = netflixPlans.Price(120.49);
            ViewBag.Content = netflixPlans.Content("Film-Dizi-Animasyon-Korku");
            ViewBag.Resolution = netflixPlans.Resolution("2k");

            return View();
        }
    }
}
