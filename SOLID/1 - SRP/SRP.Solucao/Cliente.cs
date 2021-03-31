using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solucao
{
    class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime Date { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
