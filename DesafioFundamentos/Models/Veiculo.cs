namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public Veiculo() { }
        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public string Placa { get; set; }
    }
}
