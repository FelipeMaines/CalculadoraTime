using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTime
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        { 

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║     Calculadora Tabajara         ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║ 1.  Efetuar uma Soma             ║");
            Console.WriteLine("║ 2.  Efetuar uma Subtração        ║");
            Console.WriteLine("║ 3.  Efetuar uma Multiplicação    ║");
            Console.WriteLine("║ 4.  Efetuar uma Divisão          ║");
            Console.WriteLine("║ 0.  Fechar a Calculadora         ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.Write("Digite a opção desejada: ");

            string opcao = Console.ReadLine();

            return opcao;




        }
    }
}
