using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel_CSharp.Models
{
    public class Reserva
    {
        // Construtores
        public Reserva()
        {
            Hospedes = null;
            Suite = null;
            DiasReservados = 0;
        }

        public Reserva(int diasReservados)
        {
            Hospedes = null;
            Suite = null;
            DiasReservados = diasReservados;
        }

        // Atributos
        private int _diasReservados;

        // Propriedades
        private List<Pessoa>? Hospedes { get; set; }
        private Suite? Suite { get; set; }
        public int DiasReservados
        {
            get => _diasReservados;

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Erro: A quantidade de dias reservados não pode ser menor que 1!");
                }

                _diasReservados = value;
            }
        }

        // Métodos
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null)
            {
                if (hospedes.Count > Suite.Capacidade)
                {
                    throw new Exception("Erro: Não é permitido cadastrar uma quantidade de hóspedes superior a capacidade permitida da suíte!");
                }

                Hospedes = hospedes;
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }

            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite != null)
            {
                decimal valorFinal = Suite.ValorDiaria * DiasReservados;

                if (DiasReservados >= 10)
                {
                    return valorFinal - (0.10M * valorFinal);
                }
                else
                {
                    return valorFinal;
                }
            }

            return 0.00M;
        }
    }
}