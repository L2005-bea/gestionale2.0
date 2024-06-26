using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class prenotazioniViewModels
    {
        public List<prenotazione> lista_prenotazioni;

		public prenotazione prenotazione { get; set; }
		public parrucchieri parrucchiere { get; set; }
		public parrucchieri codice_immagine { get; set; }
		public parrucchieri telefono { get; set; }
		public parrucchieri email { get; set; }
        public parrucchieri nome { get; set; }
        public parrucchieri cognome { get; set; }

        public prenotazioniViewModels(List<prenotazione> lista_prenotazioni)
        {
            this.lista_prenotazioni = lista_prenotazioni;
         

        }
    }
}
