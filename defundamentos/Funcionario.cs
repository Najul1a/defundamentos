using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    public class Funcionario : pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void ApresentarSe()
        {
            Console.WriteLine("Óla, meu nome é " + this.Nome + ", tenho" + this.Idade + " sou " + this.Cargo + " e o meu salario é" + this.Salario); ;
        }
    }
}
