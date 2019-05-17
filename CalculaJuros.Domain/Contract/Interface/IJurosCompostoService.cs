using CalculaJuros.Domain.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Contract.Interface
{
    public interface IJurosCompostoService
    {
        Task<decimal> CalculaJuros(DtoJurosCompostoCalculaJurosRequest request);
    }
}
