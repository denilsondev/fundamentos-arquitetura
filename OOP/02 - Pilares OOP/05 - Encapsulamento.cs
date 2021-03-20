using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Encapsulamento é a arte de encapsular comportamento atraves da exposicao de metodos publicos e tambem da escrita de metodos privados.
    class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraEspressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();

        }
    }
}
