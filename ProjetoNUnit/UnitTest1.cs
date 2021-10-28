using NUnit.Framework;

namespace ProjetoNUnit
{
    public class Tests
    {
       [Test]
        public void MaiorDeIdade()
        {
            int idade = 20;
            bool resultado = Helpers.MaiorDeIdade(idade);
            Assert.IsTrue(true);
        }

           [Test]
        public void MenorDeIdade()
        {
            int idade =52;
            bool resultado=Helpers.MenorDeIdade(idade);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void RetornaSomaDeDoisNumeros()
        {
          var num1 = 2;
          var num2 = 5;
          var resultadoEsperado = 7;
          var resultadoObtido = num1 + num2;
          
          Assert.AreEqual(resultadoEsperado, resultadoObtido);
        }

        
    }


}