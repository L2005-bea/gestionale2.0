using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class PrenotazioneViewModels
    {
        public List<cliente> lista_clienti;
        public prenotazione prenotazione { get; set; }
        public parrucchieri parrucchiere { get; set; }

        public int SelectedClienteId { get; set; }

        public PrenotazioneViewModels(List<cliente> lista_clienti, prenotazione prenotazione, parrucchieri parrucchiere)
        {
            this.prenotazione = prenotazione;
            this.lista_clienti = lista_clienti;
            this.parrucchiere = parrucchiere;
        }
    }
}
