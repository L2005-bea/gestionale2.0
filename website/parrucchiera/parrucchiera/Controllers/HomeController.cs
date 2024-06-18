using Microsoft.AspNetCore.Mvc;
using parrucchiera.Models;
using parrucchiera.viewmodels;
using parrucchiera.Data;
using System.Diagnostics;
using System.Data.SqlClient;

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
        public IActionResult prenotazione()
        {
            return View();
        }
        public IActionResult Storia()
        {
            return View();
        }
        public IActionResult appuntamento()
        {
            List<prenotazione> lista_di_prenotazione = new List<prenotazione>();
            SQLData db = new SQLData();
            lista_di_prenotazione = db.GetCaricaappuntamento();
            return View(new prenotazioneViewModels(lista_di_prenotazione));
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
            List<parrucchieri> lista_di_parrucchieri = new List<parrucchieri>();
            SQLData db = new SQLData();
            lista_di_parrucchieri = db.GetCaricaParrucchieri();
            return View(new parrucchieriViewModels(lista_di_parrucchieri));
        }

        [HttpPost]
        public IActionResult appuntamento(parrucchieri parrucchiere)
      {
            SQLData db = new SQLData();

            db.CreaParrucchiere(parrucchiere);
            List<parrucchieri> lista_di_parrucchieri = new List<parrucchieri>();

            lista_di_parrucchieri = db.GetCaricaParrucchieri();
            return View(new parrucchieriViewModels(lista_di_parrucchieri));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
