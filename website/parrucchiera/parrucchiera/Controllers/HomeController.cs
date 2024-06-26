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

        public IActionResult Storia()
        {
            return View();
        }
        /*------------------------------------------------------------------*/
        /* GESTIONE DELLA PRENOTAZIONE CON DATI SU CHI PRENOTA E CON CHI E DATA. CON HTTP POST GESTIAMO L'INSERIMENTO 
         * DI UNA NUOVA PRENOTAZIONE*/
        [HttpPost]
		public IActionResult Prenotazione(prenotazione prenotazione, int SelectedClienteId, parrucchieri parrucchiere)
		{
			SQLData db = new SQLData();

			db.CreaPrenotazione(prenotazione, SelectedClienteId, parrucchiere);

			return RedirectToAction("Prenotazioni", "Home");
		}
		public IActionResult Prenotazione(int IDParrucchiere)
		{
			List<cliente> lista_clienti = new List<cliente>();
            prenotazione prenotazione = new prenotazione();
            parrucchieri parrucchiere = new parrucchieri();
			parrucchieri codice_immagine = new parrucchieri();
            parrucchieri nome = new parrucchieri();
            parrucchieri cognome = new parrucchieri();

            SQLData db = new SQLData();
           
            lista_clienti = db.GetCaricaListaClienti();
            parrucchiere = db.GetCaricaParrucchiere(IDParrucchiere);

			return View(new PrenotazioneViewModels(lista_clienti, prenotazione, parrucchiere, codice_immagine,nome,cognome));
		}
        /*------------------------------------------------------------------*/

        public IActionResult Prenotazioni()
        {
            List<prenotazione> lista_prenotazioni = new List<prenotazione>();
           

            SQLData db = new SQLData();
            lista_prenotazioni = db.GetCaricaListaPrenotazioni();

            return View(new prenotazioniViewModels(lista_prenotazioni));

        }


        /*------------------------------------------------------------------*/
        /* GESTIONE DEI CLIENTI, CREAZIONE + LISTA */
        public IActionResult Cliente(cliente cliente)
		{
			return View();
		}

		[HttpPost]
		public IActionResult cliente(cliente cliente)
		{
			SQLData db = new SQLData();

            db.Creacliente(cliente);
			return View();
		}
        /*------------------------------------------------------------------*/

        /* CARICAMENTO DELLA LISTA DEI SERVIZI */
        public IActionResult Servizi()
        {
            List<servizi> lista_di_servizi = new List<servizi>();
            SQLData db = new SQLData();
            lista_di_servizi = db.GetCaricaServizi();
            return View(new serviziViewModels(lista_di_servizi));
        }
        /*------------------------------------------------------------------*/
        /*LISTA DEI PARRUCCHIERI E GESTIONE DELLA CREAZIONE IN POST DI UN NUOVO PARRUCCHIERE */
        public IActionResult Parrucchieri()
        {
            List<parrucchieri> lista_di_parrucchieri = new List<parrucchieri>();
            SQLData db = new SQLData();
            lista_di_parrucchieri = db.GetCaricaParrucchieri();
            return View(new parrucchieriViewModels(lista_di_parrucchieri));
        }

        [HttpPost]
        public IActionResult Parrucchieri(parrucchieri parrucchiere)
      {
            SQLData db = new SQLData();

            db.CreaParrucchiere(parrucchiere);
            List<parrucchieri> lista_di_parrucchieri = new List<parrucchieri>();

            lista_di_parrucchieri = db.GetCaricaParrucchieri();
            return View(new parrucchieriViewModels(lista_di_parrucchieri));
        }
        /*------------------------------------------------------------------*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
