using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Cases
    {
        #region Caso 1

        public class PessoaFisica : Pessoa
        {
            public string Cpf { get; set; }
        }

        public class PessoaFisic2
        {
            public Pessoa Pessoa { get; set; }
            public string Cpf { get; set; }
        }

        public class TestesHerancaComposicao
        {
            public TestesHerancaComposicao()
            {
                var pessoaHeranca = new PessoaFisica
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                    Cpf = "1234567"
                };

                var pessoaComposicao = new PessoaFisic2
                {
                    Pessoa = new Pessoa
                    {
                        Nome = "Joao",
                        DataNascimento = DateTime.Now,
                    },
                    Cpf = "12345678"
                };

                var nomeHeranca = pessoaHeranca.Nome;
                var nomeComposicao = pessoaComposicao.Pessoa.Nome;
            }
        }


        #endregion

        #region Caso 2

        #endregion
    }
}
