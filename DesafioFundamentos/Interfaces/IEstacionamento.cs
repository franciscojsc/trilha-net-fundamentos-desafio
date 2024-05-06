using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Interfaces
{
    public interface IEstacionamento
    {
        /// <summary>
        /// Adiciona veículo no estacionamento
        /// </summary>
        public void AdicionarVeiculo();

        /// <summary>
        /// Remove veículo no estacionamento
        /// </summary>
        public void RemoverVeiculo();

        /// <summary>
        /// Lista os veículos no estacionamento
        /// </summary>
        public void ListarVeiculos();

        /// <summary>
        /// Processa o valor do pagamento pelo estacionamento
        /// </summary>
        /// <param name="precoInicial"></param>
        /// <param name="precoPorHora"></param>
        /// <returns></returns>
        public decimal ProcessarPagamento(decimal precoInicial, decimal precoPorHora);
    }
}
