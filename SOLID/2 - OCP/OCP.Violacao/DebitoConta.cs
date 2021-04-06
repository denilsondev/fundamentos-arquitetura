using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //Debita Conta Corrente
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                //Valida Aniversario da Conta
                //Debita Conta Poupança
            }
        }

    }
}
