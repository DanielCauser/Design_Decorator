using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.FitroDeContas
{
    public class Conta
    {
        public double Valor { get; set; }
        public DateTime DataAbertura { get; set; }

        public Conta(double valor, DateTime dataAbertura)
        {
            this.Valor = valor;
            this.DataAbertura = dataAbertura;
        }
    }
}
