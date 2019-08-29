using NUnit.Framework;
using System;

namespace CadastroDeNascimento.Tests
{
    public class CalculoIdadeTests
    {
        [TestFixture]
        public class MetodosTests
        {
            [Test]
            public void DeveRetornarIdade()
            {
                var sut = new Metodos();

                DateTime data = new DateTime(23, 01, 1995);
                var resultado = sut.calculaIdade(data);

                Assert.That(resultado, Is.EqualTo(24));
            }

            [Test]
            public void DeveSomarDoisNumeros()
            {
                var sut = new Metodos();
                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

        }
    }
}
