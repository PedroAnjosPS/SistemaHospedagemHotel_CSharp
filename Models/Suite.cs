using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel_CSharp.Models
{
    public class Suite
    {
        // Construtores
        public Suite()
        {
            _tipoSuite = "";
            _capacidade = 0;
            _valorDiaria = 0.00M;
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        // Atributos
        private string? _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        // Propriedades
        public string TipoSuite
        {
            get => (_tipoSuite != null) ? _tipoSuite : "";

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Erro: O tipo da suíte não pode ser vazio!");
                }

                _tipoSuite = value;
            }
        }
        public int Capacidade
        {
            get => _capacidade;

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Erro: A capacidade não pode ser menor do que 1!");
                }

                _capacidade = value;
            }
        }
        public decimal ValorDiaria
        {
            get => _valorDiaria;

            set
            {
                if (value < 10.00M)
                {
                    throw new ArgumentException("Erro: O valor da diária não deve ser menor que o valor predeterminado!");
                }

                _valorDiaria = value;
            } 
        }
    }
}