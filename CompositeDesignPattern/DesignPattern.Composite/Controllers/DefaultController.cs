using DesignPattern.Composite.CompositePattern;
using DesignPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Categories.Include(x => x.Products).ToList();
            var values = Recursive(value, new Category { Name = "First Category", Id = 0 }, new ProductComposite(0, "First Compsite"));
            ViewBag.Values = values;
            return View();
        }

        public ProductComposite Recursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leef = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.Id).ToList()
                .ForEach(y =>
                {
                    var productComposite = new ProductComposite(y.Id, y.Name);
                    y.Products.ToList().ForEach(z =>
                    {
                        productComposite.Add(new ProductComponent(z.Id, z.Name));
                    });

                    if (leef != null)
                    {
                        leef.Add(productComposite);
                    }
                    else
                    {
                        firstComposite.Add(productComposite);
                    }

                    Recursive(categories, y, firstComposite, productComposite);
                });

            return firstComposite;
        }
    }
}
