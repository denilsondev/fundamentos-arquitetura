using ProjetoA;
using System;

namespace ProjetoB
{
    public class TesteClassess
    {
        public TesteClassess()
        {
            var publica = new Publica();
            //var privada = new Privada(); //so esta disponivel no proprio assembly
            var interna = new Interna();  //Disponivel devido ao trecho internalsVisibleTo
            //var abstrata = new Abstrata(); //nao pode ser instanciada, apenas herdada
        }

    }
}
