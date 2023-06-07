namespace CalculadoraTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal Telaprincipal = new TelaPrincipal();
            calculos calculo = new calculos();
            List<string> listaCalculos = new List<string>();
            string operacao = "";

            while (true)
            {
                string opcao = Telaprincipal.ApresentarMenu();

                decimal primeiroNumero = 0;
                decimal segundoNumero = 0;
                decimal resultado = 0;

                switch (opcao)
                {
                    case "0":
                        return; 

                    case "1":
                        operacao = "+";
                        primeiroNumero = PegarPrimeiroNumero();
                        segundoNumero = PegarSegundoNumero();
                        resultado = calculo.Somar(primeiroNumero, segundoNumero);

                        Console.WriteLine($"A resposta da opercao ficou em: {resultado}");
                        Console.ReadLine();

                        listaCalculos.Add($"{primeiroNumero} {operacao} {segundoNumero} = {resultado}");
                        break;

                    case "2":
                        operacao = "-";
                        primeiroNumero = PegarPrimeiroNumero();
                        segundoNumero = PegarSegundoNumero();
                        resultado = calculo.Subtrair(primeiroNumero, segundoNumero);

                        Console.WriteLine($"A resposta da opercao ficou em: {resultado}");
                        Console.ReadLine();

                        listaCalculos.Add($"{primeiroNumero} {operacao} {segundoNumero} = {resultado}");
                        break;

                    case "3":
                        operacao = "*";
                        primeiroNumero = PegarPrimeiroNumero();
                        segundoNumero = PegarSegundoNumero();
                        resultado = calculo.Multiplicar(primeiroNumero, segundoNumero);

                        Console.WriteLine($"A resposta da opercao ficou em: {resultado}");
                        Console.ReadLine();

                        listaCalculos.Add($"{primeiroNumero} {operacao} {segundoNumero} = {resultado}");
                        break;

                    case "4":
                        operacao = "/";
                        primeiroNumero = PegarPrimeiroNumero();
                        segundoNumero = PegarSegundoNumero();
                        resultado = calculo.Dividir(primeiroNumero, segundoNumero);

                        Console.WriteLine($"A resposta da opercao ficou em: {resultado}");
                        Console.ReadLine();

                        listaCalculos.Add($"{primeiroNumero} {operacao} {segundoNumero} = {resultado}");
                        break;


                }
            }
            
        }

        private static decimal PegarSegundoNumero()
        {
            Console.WriteLine("Qual o segundo numero?");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());
            return segundoNumero;
        }

        private static decimal PegarPrimeiroNumero()
        {
            Console.WriteLine("Qual o primeiro numero?");
            decimal primerioNumero = Convert.ToDecimal(Console.ReadLine());
            return primerioNumero;
        }
    }
}