using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao_Extension_Methods
{ 
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //Logica de nefgocio para debito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}
