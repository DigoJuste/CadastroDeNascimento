using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeNascimento.Tests
{
    public class CadastroDeNascimentoTests
    {
        [TestFixture]
        public class MetodosTests
        {
            [Test]
            public void DeveRetornarIdade1()
            {
                //Teste para data que aniversario ja passou
                var sut = new Metodos();
                DateTime data1 = new DateTime(1995, 01, 23);
                DateTime data2 = new DateTime(2019, 08, 27);
                var resultado = sut.calculaIdade(data1 , data2);

                Assert.That(resultado, Is.EqualTo(24));
            }

            [Test]
            public void DeveRetornarIdade2()
            {
                //Teste para data que aniversario não passou, e falta meses
                var sut = new Metodos();

                DateTime data1 = new DateTime(1995, 09, 23);
                DateTime data2 = new DateTime(2019, 08, 27);
                var resultado = sut.calculaIdade(data1, data2);

                Assert.That(resultado, Is.EqualTo(23));
            }

            [Test]
            public void DeveRetornarIdade3()
            {
                //Teste para data que aniversario não passou, e falta dias
                var sut = new Metodos();

                DateTime data1 = new DateTime(1995, 08, 23);
                DateTime data2 = new DateTime(2019, 08, 21);
                var resultado = sut.calculaIdade(data1, data2);

                Assert.That(resultado, Is.EqualTo(23));
            }

            [Test]
            public void Teste1VerificadorDV1DO()
            {
                
                var sut = new Metodos();

                var resultado = sut.dv1("12096654-9");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste2VerificadorDV1DO()
            {
                
                var sut = new Metodos();

                var resultado = sut.dv1("12096654-7");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }

            [Test]
            public void Teste3VerificadorDV1DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("12941231-6");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste4VerificadorDV1DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("13512796-0");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste5VerificadorDV1DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("13512796-2");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }
            [Test]
            public void Teste1VerificadorDV1DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("44231654-5");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste2VerificadorDV1DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("44231654-8");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }

            [Test]
            public void Teste3VerificadorDV1DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("46231654-7");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste4VerificadorDV1DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv1("46231654-0");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }

            [Test]
            public void TesteVerificadorDV2DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv2do("14932163-5");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste2VerificadorDV2DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv2do("14932163-6");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }
            [Test]
            public void Teste3VerificadorDV2DO()
            {

                var sut = new Metodos();

                var resultado = sut.dv2do("15932165-4");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }
            [Test]
            public void TesteVerificadorDV2DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv2dnv("30-49532165-8");

                Assert.That(resultado, Is.EqualTo("Numero Valido"));
            }

            [Test]
            public void Teste2VerificadorDV2DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv2dnv("30-49532165-6");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }

            [Test]
            public void Teste3VerificadorDV2DNV()
            {

                var sut = new Metodos();

                var resultado = sut.dv2dnv("31-49532165-8");

                Assert.That(resultado, Is.EqualTo("Numero Invalido"));
            }
        }
    }
}
