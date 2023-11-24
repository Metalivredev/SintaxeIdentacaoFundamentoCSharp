using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxeIdentacao.Acessorios
{
    public class Clock
    {
        public string? Modell { get; set; } //Modelo
        public string? Type { get; set; } // This is Digital or Analgic. 
        public string? BackGround { get; set; } //Imagem the background or color using.

        public void Exposition()
        {
            Console.WriteLine("Para a geração do inventário pessoal é necessário informar os seguintes detalhes do seu relógio.");
            Console.WriteLine("Modelo: ");
            Modell = Console.ReadLine();
            Console.WriteLine("Digital or Analogic: ");
            Type = Console.ReadLine();
            Console.WriteLine("Detalhes do fundo: ");
            BackGround = Console.ReadLine();

            Console.WriteLine($"O seu {Modell} foi registrado em nosso banco de dados. \n Devido a preciosidade {Type}, ele terá prioridade em nosso inventário. Certifique-se de que o {BackGround} também conta com itens valisos. \n Logo logo estaremos em sua localidade!");
        }

    }
}