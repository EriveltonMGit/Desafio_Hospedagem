using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reserva_hotel
{
    // Representa a reserva feita por hóspedes em uma suíte por um determinado número de dias
    public class Reserva
    {
        // Lista dos hóspedes que farão parte da reserva
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();

        // A suíte escolhida para a reserva
        public Suite Suite { get; set; }

        // Quantidade de dias reservados para a estadia
        public decimal DiasReservados { get; private set; }

        // Construtor da classe que inicializa a reserva com o número de dias e a suíte escolhida
        public Reserva(int diasReservados, Suite suite)
        {
            DiasReservados = diasReservados;
            Suite = suite ?? throw new ArgumentNullException(nameof(suite)); // Garante que a suíte não seja null
        }

        // Método para cadastrar hóspedes na reserva
        // Valida se a quantidade de hóspedes não excede a capacidade da suíte
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança exceção se a capacidade for excedida
                throw new Exception("Capacidade da suíte excedida.");
            }
        }

        // Retorna a quantidade atual de hóspedes na reserva
        public int ObterQuantidade()
        {
            return Hospedes.Count;
        }

        // Calcula o valor total da diária da reserva
        // Aplica desconto de 10% para reservas com mais de 10 dias
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                valor *= 0.90m; // Aplica desconto de 10%
            }
            return valor;
        }
    }
}
