using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class PrenotazioneViewModels
    {
        public List<cliente> lista_clienti;
        public prenotazione prenotazione { get; set; }
        public parrucchieri nome { get; set; }
        public parrucchieri cognome { get; set; }


        public parrucchieri parrucchiere { get; set; }
		public parrucchieri codice_immagine { get; set; }

		public int SelectedClienteId { get; set; }

        public PrenotazioneViewModels(List<cliente> lista_clienti, prenotazione prenotazione, parrucchieri parrucchiere, parrucchieri codice_immagine,parrucchieri cognome,parrucchieri nome)
        {
            this.prenotazione = prenotazione;
            this.lista_clienti = lista_clienti;
            this.parrucchiere = parrucchiere;
			this.codice_immagine = codice_immagine;
            this.cognome = cognome;
            this.nome = nome;
        }
    }
}
