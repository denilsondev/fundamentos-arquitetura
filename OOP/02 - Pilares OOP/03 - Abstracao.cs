using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //criar conceitos genericos que podem ser abstraidos por outra classe;
    //uma classe abastrata nao pode ser instanciada diretamente. A classe abastrata é a base de uma outra classe
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly string _voltagem;

        protected Eletrodomestico(string nome, string voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        };

        public abstract void Ligar();
        public abstract void Desligar();

    }
}
