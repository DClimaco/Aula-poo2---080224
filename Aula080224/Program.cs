using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula080224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean op = true;
            do 
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("0 - Sair");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        op = false;
                        break;

                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        int z = int.Parse(Console.ReadLine());
                        int a = y + z;
                        Console.WriteLine("O resultado da soma é {0}", a);
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número:");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        int c = int.Parse(Console.ReadLine());
                        int d = b - c;
                        Console.WriteLine("O resultado da subtração é {0}", d);
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número:");
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        int f = int.Parse(Console.ReadLine());
                        int g = e / f;
                        Console.WriteLine("O resultado da soma é {0}", g);
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número:");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        int i = int.Parse(Console.ReadLine());
                        int j = h * i;
                        Console.WriteLine("O resultado da soma é {0}", j);
                        break;

                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }
            } while (op);
        }
    }
}
