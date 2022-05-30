using Lab2.Common.Contracts;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IArchitectureRepository _repository;

        public OrderController(IArchitectureRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var result = _repository.GetOrders();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddOrder(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddOrder(Order order)
        {
            _repository.AddOrders(order);
            return "Order," + order.Id + ",Added";
        }
    }
}
