using NUnit.Framework;

namespace ProjetoNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TesteSoma()
        {
            // Definição das variáveis
            int a = 5;
            int b = 6;

            // Validação correta no formato recomendado
            Assert.That(a + b, Is.EqualTo(11));
        }

        [Test]
        public void TesteNome()
        {
            // Definição das variáveis
            string a = "Bruno ";
            int b = 6;

            // Validação correta no formato recomendado
            Assert.That(a + b.ToString(), Is.EqualTo("Bruno 6"));

            
        }
    }
}
