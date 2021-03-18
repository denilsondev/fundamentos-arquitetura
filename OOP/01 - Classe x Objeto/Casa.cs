using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._01___Classe_x_Objeto
{

    // Uma classe é uma estrutura de codigo que tem a função de mapear um objeto do mundo real.
    class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }


    // Um objeto é a classe sendo instanciada e alocada na memoria
    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 10000,
                NumeroVagas = 3
            };
        }
    }
}
