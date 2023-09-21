using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryDesignPattern.Business.Abstract;
using RepositoryDesignPattern.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignPattern.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _productService.TListWithCategory();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> categories = (from x in _categoryService.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();

            ViewBag.Categories = categories;

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<SelectListItem> categories = (from x in _categoryService.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();

            ViewBag.Categories = categories;

            var product = _productService.TGetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}
