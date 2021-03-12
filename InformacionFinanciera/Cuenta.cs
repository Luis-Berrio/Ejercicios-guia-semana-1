using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionFinanciera
{
    public class Cuenta
    {
        //private decimal saldo;

        public decimal saldo { get; set; }
        public void ConsignarSaldo(decimal valor)
        {
            saldo += valor;
        }

        public void Retirar(decimal valor)
        {
            saldo -= valor;
        }

        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
