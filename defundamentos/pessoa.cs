using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    public class pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer(int anos)
        {
            this.Idade += anos;
            Console.WriteLine(this.Nome + ", Sua idade agora é " + this.Idade);
        }
    }
}
