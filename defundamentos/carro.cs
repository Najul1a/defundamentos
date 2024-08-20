using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    public class carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        //Modelo
        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("velocidade Atual é" + this.Velocidade + "km/h");
        }

        public void Desacelerando()
        {
            this.Velocidade -= 5;
            Console.WriteLine("velocidade Atual é" + this.Velocidade + "km/h");

        }

    }
}
