using parrucchiera.Models;
namespace parrucchiera.viewmodels
{
    public class parrucchieriViewModels
    {
        public List<parrucchieri> parrucchieri { get; set; }

        public parrucchieri parrucchiere { get; set; }

        public parrucchieriViewModels(List<parrucchieri> parrucchieri)
        {
            this.parrucchieri = parrucchieri;
        }
    }
}


