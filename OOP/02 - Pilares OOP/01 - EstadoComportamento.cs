using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Pessoa
    {
        //Estados são as propriedades da classe;
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //comportamentos são metodos da classe que processam uma informação, que devolve informação ou que alteram o estado da classe;
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;
            return idade;
        }
    }
}
