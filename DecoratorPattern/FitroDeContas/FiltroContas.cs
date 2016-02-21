using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.FitroDeContas
{
    public abstract class FiltroContas
    {
        public FiltroContas outroFiltro { get; set; }

        public FiltroContas()
        {
            this.outroFiltro = null;
        }
        public FiltroContas(FiltroContas f)
        {
            this.outroFiltro = f; 
        }

        public abstract List<Conta> Filtrar(List<Conta> c);

        protected List<Conta> FiltrarNovamente(List<Conta> contas)
        {
            if (outroFiltro != null) return outroFiltro.Filtrar(contas);
            else return new List<Conta>();
        }
        
    }
}
