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
            List<paruchiera> lista_di_parruchiera = new List<paruchiera>();
            SQLData db = new SQLData();
			lista_di_paruchiera  = db.CaricaParuchiera();			
			return View(new serviziViewModels(lista_di_paruchiera));
        }
		public IActionResult Servizi()
		{
			List<servizi> lista_di_servizi = new List<servizi>();
			SQLData db = new SQLData();
			lista_di_servizi = db.CaricaServizi();
			return View(new serviziViewModels(lista_di_servizi));
		}
		public IActionResult appuntamento()
		{
			
			return View();
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
