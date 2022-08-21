using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfromNet.models
{
    internal class Carro
    {
        public Carro() { }
        public Carro(string cor, string placa)
        {
            Cor = cor;
            Placa = placa;
        }
        public int ID { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

    }
}
