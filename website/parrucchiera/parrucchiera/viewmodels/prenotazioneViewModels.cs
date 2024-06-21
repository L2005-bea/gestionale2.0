using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class PrenotazioneViewModels
    {
        public prenotazione prenotazione { get; set; }

        public PrenotazioneViewModels(prenotazione prenotazione)
        {
            this.prenotazione = prenotazione;
        }

		public class clienteViewModels
		{
			public cliente cliente { get; set; }

			public clienteViewModels(cliente cliente)
			{
				this.cliente = cliente;
			}


		}

	}
}

