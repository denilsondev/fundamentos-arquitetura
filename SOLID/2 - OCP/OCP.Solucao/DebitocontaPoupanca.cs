using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao
{
    public class DebitocontaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //valida Aniversario da Conta
            //Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
