using Lab2.Common.Contracts;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArchitectureRepository _repository;

        public ArtistController(IArchitectureRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllArtist()
        {
            var result = _repository.GetArtists();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddArtist(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddArtist(Artist artist)
        {
            _repository.AddArtists(artist);
            return "Artist," + artist.Id + ",Added";
        }
    }
}
