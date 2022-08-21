using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfromNet.models
{
    internal class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Pessoa()
        {
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

    }
}
