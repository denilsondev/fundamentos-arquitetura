using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Herança é um meio de voce herdar todos as propriedades e métodos da classe mãe
    // Classe base "É uma" classe mãe. Ex: Funcionario É UMA Pessoa. Se isso nao fizer sentido, significa que não deveria ter este tipo de herança. Nunca isso podera ser pensado na estrategia de economizar implementação.
    class Funcionario : Pessoa 
    {
        public DateTime DataAdmissao { get; set; }
        public int Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funconario = new Funcionario()
            {
                Nome = "Joao da silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = 1234
            };
        }
    }
}
