using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("apenas Soma, Subtracao, Multiplicacao e Divisao");
            string operacao = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());
            double resultado = 0;

            // if (operacao == "Soma") {
            //     resultado = numero1 + numero2;
            // } else if (operacao == "Subtracao") {
            //     resultado = numero1 - numero2;
            // } else if (operacao == "Multiplicacao") {
            //     resultado = numero1 * numero2;
            // } else if  (operacao == "Divisao") {
            //     resultado = numero1 / numero2;
            // } else {
            //     Console.WriteLine("Operação inválida");
            //     invalido = true;
            // }
            
            switch (operacao)
            {
                case "SOMA":
                    resultado = numero1 + numero2;
                    break;
                case "SUBTRACAO":
                    resultado = numero1 - numero2;
                    break;
                case "MULTIPLICACAO":
                    resultado = numero1 * numero2;
                    break;
                case "DIVISAO":
                    resultado = numero1 / numero2;
                    break;
                default:
                operacao = "invalida";
                Console.WriteLine("Operação inválida");
                    break;
            }
            if (operacao != "invalida"){
                Console.WriteLine($"A {operacao} entre {numero1} e {numero2} é igual a {resultado}");
            }
            
        }
    }
}
