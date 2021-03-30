namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }


    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {

        }

    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {

        }

    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImImplementacao
    {
        public TesteInterfaceImImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoImplementacao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();

        }
    }
}



