using CalculaJuros.Domain.Contract.Dto;
using CalculaJuros.Domain.Contract.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Service
{
    public class JurosCompostoService : IJurosCompostoService
    {
        public async Task<decimal> CalculaJuros(DtoJurosCompostoCalculaJurosRequest request)
        {
            //apenas para ter um await
            await Task.Run(() => { });

            if (request.ValorInicial <= 0)
            {
                throw new ArgumentNullException("ValorInicial");
            }
            if (request.Meses <= 0)
            {
                throw new ArgumentNullException("Meses");
            }

            var valorFinal = request.ValorInicial * (decimal)Math.Pow(1.01D, request.Meses);

            return Math.Round(valorFinal, 2);
        }
    }
}
