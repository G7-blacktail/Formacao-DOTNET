using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e minha idade é {Idade}");
        }
    }
}