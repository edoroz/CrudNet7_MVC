using CrudNet7MVC.Contexto;
using CrudNet7MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CrudNet7MVC.Controllers {
    public class HomeController:Controller {
        private readonly AppDbContext _contexto;

        public HomeController(AppDbContext contexto) {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<IActionResult> Index() {
            return View(await _contexto.Contacto.ToListAsync());
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}