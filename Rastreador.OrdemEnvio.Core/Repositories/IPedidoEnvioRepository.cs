﻿using Rastreador.OrdemEnvio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Core.Repositories
{
    public interface IPedidoEnvioRepository
    {
        Task<PedidoEnvio> GetByCodeAsync(string code);
        Task AddAsync(PedidoEnvio entity);
    }
}