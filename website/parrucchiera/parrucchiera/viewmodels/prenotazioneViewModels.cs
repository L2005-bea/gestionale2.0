using parrucchiera.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace parrucchiera.viewmodels
{
	public class PrenotazioneViewModels
	{
		public List<cliente> lista_clienti;
	
		public prenotazione prenotazione { get; set; }
		public parrucchieri parrucchiere { get; set; }
		public  parrucchieri codice_immagine { get; set; }
		public  parrucchieri telefono { get; set; }
		public  parrucchieri email { get; set; }

		public int SelectedClienteId { get; set; }

		public PrenotazioneViewModels(List<cliente> lista_clienti, prenotazione prenotazione, parrucchieri parrucchiere, parrucchieri telefono, parrucchieri email, parrucchieri codice_immagine)
        {
			this.prenotazione = prenotazione;
			this.lista_clienti = lista_clienti;
			this.parrucchiere = parrucchiere;
			this.telefono = telefono;
			this.email = email;
			this.codice_immagine = codice_immagine;


	}
	}
}
