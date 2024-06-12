using parrucchiera.Models;
namespace parrucchiera.viewmodels
{
    public class serviziViewModels
    {
        public List<servizi> servizi { get; set; }

            public serviziViewModels (List<servizi> servizi)
        {
            this.servizi = servizi;
        }
    }
}
