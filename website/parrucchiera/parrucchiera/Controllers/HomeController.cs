using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using parrucchiera.Models;
using parrucchiera.viewmodels;
using Parrucchiera.Data;
namespace parrucchiera.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Storia()
        {
            return View();
        }

        public IActionResult Parrucchiera()
        {
            List<parrucchiera> lista_di_parrucchiera = new List<parrucchiera>();
            SQLData db = new SQLData();
			lista_di_parrucchiera  = db.CaricaParrucchiera();			
			return View(new serviziViewModels(lista_di_parrucchiera));
        }
		public IActionResult Servizi()
		{
			List<servizi> lista_di_servizi = new List<servizi>();
			SQLData db = new SQLData();
			lista_di_servizi = db.GetCaricaServizi();
			return View(new serviziViewModels(lista_di_servizi));
		}
		public IActionResult appuntamento()
		{
			
			return View();
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new parrucchieraViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
