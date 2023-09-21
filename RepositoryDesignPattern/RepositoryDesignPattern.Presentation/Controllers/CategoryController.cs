using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Business.Abstract;
using RepositoryDesignPattern.Entity.Concrete;

namespace RepositoryDesignPattern.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.TGetList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _categoryService.TGetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
