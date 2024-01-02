using System;
using System.ComponentModel.Design;

class Program {
    public static void Main(string[] args) {

        int numero, tentativas, valorUsuario;
        numero = 55;
            
        

        for (tentativas = 1; 1 <= 5; tentativas++) {
            Console.WriteLine("Digite um número de 0 a 100");
            valorUsuario = int.Parse(Console.ReadLine());

            if (valorUsuario == numero) {
                Console.WriteLine("Acertou");
                break;
            }
            else if (tentativas == 5) { 
                Console.WriteLine("Errou, jogo encerrado");
                break;
            }
        }

    }
}