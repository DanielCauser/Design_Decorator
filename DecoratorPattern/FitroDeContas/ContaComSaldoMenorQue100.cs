using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.FitroDeContas
{
    public class ContaComSaldoMenorQue100 : FiltroContas
    {
        public ContaComSaldoMenorQue100()
            : base()
        {
        }
        public ContaComSaldoMenorQue100(FiltroContas f)
            : base(f)
        {
        }
        public override List<Conta> Filtrar(List<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Valor < 100) filtrada.Add(c);
            }
            foreach (Conta c in FiltrarNovamente(contas))
            {
                filtrada.Add(c);
            }
            return filtrada.ToList();
        }
    }
}
