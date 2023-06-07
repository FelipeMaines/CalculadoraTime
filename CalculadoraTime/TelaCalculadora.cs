using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTime
{
    internal class TelaCalculadora
    {
        static void Main() 
        {
            while (true)
            {
                TelaCalculadora.ExibirMenuCalculadora();

                Console.Write("Digite o numero da operacao desejada");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 5) 
                {
                    Console.WriteLine("Saindo.");
                    break;
                }
                Console.Write("Digite o primeiro numero: ");
                double numeroUm = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                double numeroDois = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao) 
                {
                    case 1:
                        resultado = numeroUm + numeroDois;
                        break
                    case 2:
                }
            }
        }

        public static void ExibirMenuCalculadora()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Selecione uma operacao");
            Console.WriteLine("1 Para somar!");
            Console.WriteLine("2 Para Subtracao");
            Console.WriteLine("3 Para Multiplicacao");
            Console.WriteLine("4 Para divisao");
            Console.WriteLine("5 para sair");
        }
    }
    static void Main()
}
