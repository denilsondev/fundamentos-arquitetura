using SOLID.SRP.Solucao;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solucaos
{
    class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo", "Cliente cadastrado com sucesso");

            return "Cliente cadastrado com sucesso";
        }
    }
}
