using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using parrucchiera.Models;
using parrucchiera.viewmodels;

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

        public IActionResult Servizi()
        {
            List<servizi> lista_di_servizi = new List<servizi>();
            servizi newservizio1 = new servizi()
            {
                id = 1,
               nome_servizio = "image_url",
                descrizione_servizio = "This is a test game."    ,         
                prezzo = 50
            };
           lista_di_servizi.Add(newservizio1);
			servizi newservizio2 = new servizi()
			{
				id = 1,
				nome_servizio = "acconciatura",
				descrizione_servizio = "sabaku.",
				prezzo = 30
			};
			lista_di_servizi.Add(newservizio2);

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
