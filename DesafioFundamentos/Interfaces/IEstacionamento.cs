using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Interfaces
{
    public interface IEstacionamento
    {
        public void AdicionarVeiculo();

        public void RemoverVeiculo();

        public void ListarVeiculos();
    }
}
