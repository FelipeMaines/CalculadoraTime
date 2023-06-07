using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTime
{
    public class calculos
    {

        public decimal Somar(decimal primerioNumero, decimal segundoNumero)
        {
            return primerioNumero + segundoNumero;
        }

        public decimal Subtrair(decimal primerioNumero, decimal segundoNumero)
        {
            return primerioNumero - segundoNumero;
        }

        public decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
             return primeiroNumero / segundoNumero;
        }

        public decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        public void verificar()
        {
            return;
        }
    }

    
}
