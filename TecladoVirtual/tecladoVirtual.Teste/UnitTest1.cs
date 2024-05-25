using TecladoVirtual.Modelos;

namespace tecladoVirtual.Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Controle controle = new Controle("gabriel",22);
            controle.setSatisfacao(true, false, false, false, false);
        
        }

        [Test]
        public void Test1()
        {
            Assert.Equals(Convert.ToString(Estatica.mediaDasSastifacoes[0]),100);
            
        }
    }
}