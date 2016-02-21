using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imposto impostoComplexo = new ISS(new ICMS());
            //Imposto impostoComplexo = new ISS();
            Imposto impostoComplexo = new ICMS(new ISS(new ImpostoMuitoAlto()));
            Orcamento orcamento = new Orcamento(500.0);
            double valor = impostoComplexo.Calcula(orcamento);
            Console.WriteLine(valor);
            Console.ReadKey();

        }
    }
}
