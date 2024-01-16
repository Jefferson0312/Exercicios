using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
class Program {
    public static void Main(string[] args) {

        int numero;

        for (int cont = 0; cont < 5; cont++) {
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero % 2 == 0) {
                Console.WriteLine("Par Positivo");
            }

            else if (numero < 0 && numero % 2 == 0) {
                Console.WriteLine("Par Negativo");

            }

            else if (numero > 0 && numero % 2 != 0) {
                Console.WriteLine("Impar Positivo");
            }

            else if (numero < 0 && numero % 2 != 0) {
                Console.WriteLine("Impar Negativo");
            }

            else {
                Console.WriteLine("Nulo");
            }
        }

    }
}