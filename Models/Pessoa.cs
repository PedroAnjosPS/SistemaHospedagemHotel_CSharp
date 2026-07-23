using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel_CSharp.Models
{
    public class Pessoa
    {
        // Construtores
        public Pessoa()
        {
            Nome = "";
            Sobrenome = "";
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Atributos
        private string? _nome;
        private string? _sobrenome;

        // Propriedades
        public string Nome
        {
            get => (_nome != null) ? _nome : "";

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Erro: O nome não pode ser vazio!");
                }

                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => (_sobrenome != null) ? _sobrenome : "";

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Erro: O sobrenome não pode ser vazio!");
                }

                _sobrenome = value;
            }
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
    }
}