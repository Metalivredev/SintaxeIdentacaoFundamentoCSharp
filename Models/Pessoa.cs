using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxeIdentacao.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresetar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos de idade.");
        }
    }
}