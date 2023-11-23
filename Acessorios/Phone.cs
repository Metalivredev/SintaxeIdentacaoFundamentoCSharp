using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxeIdentacao.Acessorios
{
    public class Phone
    {
        public string? Marca { get; set; }
        public string? Operadora { get; set; }
        public string? SO { get; set; }
        public string? Numero { get; set; }

        public void Characters()
        {
            Console.WriteLine("Registro em andamento!");
            Console.Write("Marca do Smartphone: ");
            Marca = Console.ReadLine();
            Console.Write("Operadora: ");
            Operadora = Console.ReadLine();
            Console.Write("Sistema Operacional: ");
            SO = Console.ReadLine();
            Console.Write("Número do Chipe: ");
            Numero = Console.ReadLine();
            
            Console.WriteLine($"Foram registrados Marca: {Marca} \n Operadora: {Operadora} \n Sistema Operacional: {SO} \n Número: {Numero}.");
        }

    }
}