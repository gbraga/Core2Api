using Bogus;
using CursoOnline.DominioTest._Utils;
using ExpectedObjects;
using RelatorioApi.Dominio.Entities;
using RelatorioApiTest._Builders;
using System;
using Xunit;
using Xunit.Abstractions;

namespace RelatorioApiTest.Models
{
    public class PeriodoTest : IDisposable
    {
        private readonly ITestOutputHelper _output;

        private readonly DateTime _dataInicio;
        private readonly DateTime _dataFinal;

        public PeriodoTest(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Executando inicialização.");

            var faker = new Faker();

            _dataInicio = faker.Date.Recent();
            _dataFinal = faker.Date.Future(1, _dataInicio);
        }

        public void Dispose()
        {
            _output.WriteLine("Executando limpeza.");
        }

        [Fact]
        public void DeveCriarPeriodo()
        {
            var faker = new Faker();

            var periodoEsperado = new
            {
                DataInicio = faker.Date.Recent(),
                DataFinal = faker.Date.Future(1, _dataInicio),
            };

            var periodo = new Periodo(periodoEsperado.DataInicio, periodoEsperado.DataFinal);

            periodoEsperado.ToExpectedObject().ShouldMatch(periodo);
        }

        [Fact]
        public void NaoDevePeriodoTerDataInicioMaiorQueDataFinal()
        {
            Assert.Throws<ArgumentException>(() =>
                PeriodoBuilder.New()
                    .ComDataInicio(_dataFinal)
                    .ComDataFinal(_dataInicio)
                    .Build())
                .ComMensagem("DataInicio não pode ser maior ou igual a DataFinal.");
        }
    }
}
