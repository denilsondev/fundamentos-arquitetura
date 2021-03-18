using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // A base do polimorfismo é Abstração e herança;
    // Com base na classe base abstrata, isso faz com que a classe especializada sobscreva os metodos abastratos
    class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem)
        {

        }
        public CafeteiraEspressa() : base("Padrao", 220)
        {

        }

        private static void AquecerAgua()
        {

        }

        private static void MoerGraos()
        {

        }

        private void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();

        }
        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }

        public override void Testar()
        {
            throw new NotImplementedException();
        }
    }
}
