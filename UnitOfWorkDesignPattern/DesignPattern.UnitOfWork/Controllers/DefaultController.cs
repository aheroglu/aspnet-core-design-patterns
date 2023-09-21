using DesignPattern.Business.Abstract;
using DesignPattern.Entity.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel customerViewModel)
        {
            var sender = _customerService.TGetById(customerViewModel.SenderId);
            var receiver = _customerService.TGetById(customerViewModel.ReceiverId);

            sender.Balance -= customerViewModel.Amount;
            receiver.Balance += customerViewModel.Amount;

            List<Customer> customers = new List<Customer>
            {
                sender,
                receiver
            };

            _customerService.TMultiUpdate(customers);
            return View();
        }
    }
}
