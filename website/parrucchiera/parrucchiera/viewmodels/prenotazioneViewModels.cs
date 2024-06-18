using parrucchiera.Models;

namespace prenotazione.viewmodels
{
    public class prenotazioneViewModels
    {
        public List<prenotazione> prenotazione { get; set; }

        public prenotazione parrucchiere { get; set; }

        public prenotazione(List<prenotazione> prenotazione)
        {
            this.prenotazione = prenotazione;
        }
    }
}
