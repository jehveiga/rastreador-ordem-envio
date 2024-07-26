﻿using Rastreador.OrdemEnvio.Core.Entities;
using Rastreador.OrdemEnvio.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Dtos.InputModels
{
    public class AddPedidoEnvioInputModel
    {
        public string Descricao { get; set; }
        public decimal PesoEmKg { get; set; }
        public EnderecoEntregaInputModel EnderecoEntrega { get; set; }
        public List<EnvioServiceInputModel> Servicos { get; set; }

        public PedidoEnvio ToEntity()
            => new PedidoEnvio(
                Descricao,
                PesoEmKg,
                EnderecoEntrega.ToValueObject()
        );
    }


    public class EnderecoEntregaInputModel
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string EmailContato { get; set; }

        // Metodo resposanvel por entregar um objeto de valor EnderecoEntrega
        public EnderecoEntrega ToValueObject()
            => new EnderecoEntrega(Rua, Numero, Cep, Cidade, Estado, Pais, EmailContato);
    }

    public class EnvioServiceInputModel
    {
        public string Titulo { get; set; }
        public decimal PrecoPorKg { get; set; }
        public decimal PrecoFixado { get; set; }

        // Método responsável por entregar uma entidade EnvioService
        public EnvioService ToEntity()
            => new EnvioService(Titulo, PrecoPorKg, PrecoFixado);
    }
}
