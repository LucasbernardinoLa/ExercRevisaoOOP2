using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4.Entities
{
    internal class Pessoa
    {
        public string  Nome { get; private set; }
        public Certidao Certidao { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }public Pessoa(string nome, Certidao certidao)
        {
            Nome = nome;
            Certidao = certidao;
        }
        public override string ToString()
        {
            return $"Nome {Nome}, certidão: {Certidao}";
        }
    }
}
