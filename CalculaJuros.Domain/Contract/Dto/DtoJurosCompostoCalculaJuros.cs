using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaJuros.Domain.Contract.Dto
{
    public class DtoJurosCompostoCalculaJurosRequest
    {
        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }
    }
}
