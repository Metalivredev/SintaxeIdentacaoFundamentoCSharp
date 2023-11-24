using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxeIdentacao.ID
{
    public class Usuario
    {
        public string? RegisterNumber { get; set; }
        public string? NameFull { get; set; }
        public string? IdNumber { get; set; }
        public string? Country { get; set; }
        public string? FunctionJob { get; set; }
        public void DataRegister()
        {
            Console.WriteLine("As coisas precisam ser simples, você apenas deve responder as perguntas. Os dados você tem disponível facilmente.");
            Console.WriteLine("You Register Number: ");
            RegisterNumber = Console.ReadLine();
            Console.WriteLine("Full Name: ");
            NameFull = Console.ReadLine();
            Console.WriteLine("Id Number: ");
            IdNumber = Console.ReadLine();
            Console.WriteLine("Country: ");
            Country = Console.ReadLine();
            Console.WriteLine("Function in the you Job: ");
            FunctionJob = Console.ReadLine();
            Console.WriteLine("Thanks!");
        }
        
    }
}