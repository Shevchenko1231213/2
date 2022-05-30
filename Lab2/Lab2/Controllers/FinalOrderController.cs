using Lab2.Common.Contracts;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class FinalOrderController : Controller
    {
        private readonly IArchitectureRepository _repository;

        public FinalOrderController(IArchitectureRepository repository)
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
            var result = _repository.GetOrder();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddArtist(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddOrder(FinalOrder order)
        {
            _repository.AddOrder(order);
            return "FinalOrder," + order.Id + ",Added";
        }
    }
}
