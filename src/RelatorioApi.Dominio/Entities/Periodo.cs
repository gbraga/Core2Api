using System;

namespace RelatorioApi.Dominio.Entities
{
    public class Periodo
    {
        public Periodo(DateTime dataInicio, DateTime dataFinal)
        {
            if (dataInicio >= dataFinal)
                throw new ArgumentException("DataInicio não pode ser maior ou igual a DataFinal.");

            DataInicio = dataInicio;
            DataFinal = dataFinal;
        }

        public DateTime DataInicio { get; private set; }
        public DateTime DataFinal { get; private set; }
    }
}
