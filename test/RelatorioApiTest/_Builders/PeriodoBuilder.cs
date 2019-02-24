using System;
using Bogus;
using RelatorioApi.Dominio.Entities;

namespace RelatorioApiTest._Builders
{
    public class PeriodoBuilder
    {
        private DateTime _dataInicio { get; set; }
        private DateTime _dataFinal { get; set; }

        public static PeriodoBuilder New()
        {
            var periodo = new PeriodoBuilder();

            var faker = new Faker();

            periodo._dataInicio = faker.Date.Recent();
            periodo._dataFinal = faker.Date.Future(0, periodo._dataInicio);

            return periodo;
        }

        public PeriodoBuilder ComDataInicio(DateTime dataInicio)
        {
            _dataInicio = dataInicio;
            return this;
        }

        public PeriodoBuilder ComDataFinal(DateTime dataFinal)
        {
            _dataFinal = dataFinal;
            return this;
        }

        public Periodo Build()
        {
            return new Periodo(_dataInicio, _dataFinal);
        }
    }
}
