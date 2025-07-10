namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite == null)

            {
                throw new Exception("É necessário cadastrar uma suíte antes de cadastrar os hóspedes.");
            }

            Suite.Capacidade = hospedes.Count;

            if (Suite.Capacidade >= hospedes.Count)
            
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()

        {
            if (Hospedes == null || Hospedes.Count == 0)
            {
                throw new Exception("Nenhum hóspede cadastrado.");
            }
            else

                return Hospedes.Count;
            
        }

        public decimal CalcularValorDiaria()
        {

            if (Suite == null)
            {
                throw new Exception("É necessário cadastrar uma suíte antes de calcular o valor da diária.");
            }
            if (DiasReservados <= 0)
            {
                throw new Exception("O número de dias reservados deve ser maior que zero.");
            }

            decimal valorDiaria = Suite.ValorDiaria;

              
               if (DiasReservados >= 10)
               {
                   valorDiaria *= 0.9M; // Aplica 10% de desconto
               }

            return valorDiaria;
}
    }
}