using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class PesquisaViewModel
    {
        public PesquisaViewModel(IList<Produto> itens, bool encontrouResultado)
        {
            Itens = itens;
            EncontrouResultado = encontrouResultado;
        }

        public PesquisaViewModel(bool encontrouResultado)
        {
            EncontrouResultado = encontrouResultado;
        }

        public IList<Produto> Itens { get; }
        public string Pesquisa { get; set; }
        public bool EncontrouResultado { set; get; }
    }
}
