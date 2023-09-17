using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculadoraV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op; //opcao escolhida pelo usuario
            double valor1;
            double valor2;
            double resultado;
            resultado = 0;
            valor1 = 0;
            valor2 = 0;

            do
            {
                Console.Clear(); //Limpa a tela
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                op = int.Parse(Console.ReadLine());
                if ((op >= 1) && (op <= 4))
                {
                    Console.WriteLine("Informe o primeiro valor:");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo valor:");
                    valor2 = double.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1:
                        resultado = valor1 + valor2;
                        break;
                    case 2:
                        resultado = valor1 - valor2;
                        break;
                    case 3:
                        resultado = valor1 * valor2;
                        break;
                    case 4:
                        resultado = valor1 / valor2;
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida !");
                        break;
                }//Chave que fecha o switch
                if ((op >= 1) && (op <= 4))
                {
                    Console.WriteLine("Resultado: " + resultado);
                }
                Console.ReadKey(); //PAUSA
            } while (op != 5);
        }
    }
}