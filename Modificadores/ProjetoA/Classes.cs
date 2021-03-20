using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    #region Classes
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { }  // So pode ser instanciada e nunca ser herdada. Fechada para extensao
    class Privada { }
    internal class Interna { }
    abstract class Abstrata { }

    #endregion

    #region Testes
    class TesteClassess
    {
        public TesteClassess()
        {
            var publica = new Publica();
            var privada = new Privada(); // ok porque esta no mesmo assembly ou do mesmo tipo
            var interna = new Interna(); // ok porque esta no mesmo assembly
            //var abstrata = new Abstrata(); //class abstrata nao pode ser instanciado porque ela so pode ser herdada
        }
    }

    //class TesteSelada : Selada { } //Nao é possivel herdar classe selada

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico(); // ok porque esta dentro do assembly
            publica.TesteInternal(); // ok porque esta dentro do assembly
            publica.TesteProtegidoInterno(); //// ok porque esta dentro do assembly
            //publica.testeProtegido() // nao pode porque nao esta sendo eherdado dentro dessa classe
            //publica.testePrivadoProtegido(); //precisa herdar 
            //publica.testePrivado(); 
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico(); // ok porque esta dentro do assembly
            TesteInternal(); // ok porque esta dentro do assembly
            TesteProtegidoInterno(); //// ok porque esta dentro do assembly
            TesteProtegido(); 
            TestePrivadoProtegido(); 
            //TestePrivado(); //nao porque metodo eh privado apenas pela classe dona
        }
    }




    #endregion
}

/***********************************************************************/
//public:

// Access is not restricted.
/***********************************************************************/
//protected:

// Access is limited to the containing class or types
// derived from the containing class
/***********************************************************************/
//internal:

// Access is limited to the current assembly
/***********************************************************************/
//protected internal:

// Access islimite to the current assembly or types
// derived from the containing class.
/***********************************************************************/
//private:

// Access is limited to the containing type
/***********************************************************************/
//private protected::

// Access is limited to the containing class or types 
// derived from the conatining class within the current
// assembly.Avaible since c# 7.2
/***********************************************************************/
