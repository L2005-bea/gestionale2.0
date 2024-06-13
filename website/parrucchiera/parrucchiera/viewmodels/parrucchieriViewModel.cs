using parrucchiera.Models;
namespace parrucchiera.viewmodels
{
    public class parrucchieriViewModels
    {
        public List<parrucchieri> parrucchieri { get; set; }

        public parrucchieriViewModels(List<parrucchieri> parrucchieri)
        {
            this.parrucchieri = parrucchieri;
        }
    }
}
