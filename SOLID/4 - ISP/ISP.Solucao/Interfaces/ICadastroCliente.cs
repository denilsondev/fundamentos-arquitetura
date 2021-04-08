using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
