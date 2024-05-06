using DesafioFundamentos.Interfaces;

namespace DesafioFundamentos.Models
{
    public class Estacionamento : IEstacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                var placa = Console.ReadLine();
                var veiculo = new Veiculo(placa);
                veiculos.Add(veiculo);
            }
            catch (Exception)
            {
                Console.WriteLine("Aconteceu algum problema ao adicionar seu veículo.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(v => v.Placa.ToUpper() == placa.ToUpper()))
            {
                decimal valorTotal = ProcessarPagamento(precoInicial, precoPorHora);

                var veiculo = veiculos.FirstOrDefault(v => v.Placa.ToUpper() == placa.ToUpper());
                veiculos.Remove(veiculo);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public decimal ProcessarPagamento(decimal precoInicial, decimal precoPorHora)
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas = Convert.ToInt32(Console.ReadLine());
            return precoInicial + (precoPorHora * horas);
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.Placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
