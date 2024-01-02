using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Calculadora");

        Console.WriteLine("Digite o número da operação desejada");
        Console.WriteLine("1 = Adição");
        Console.WriteLine("2 = Multiplicação");
        Console.WriteLine("3 = Subtração");
        Console.WriteLine("4 = Divisão");
        Console.WriteLine("5 = Raiz Quadrada");

        double opcao = int.Parse(Console.ReadLine());
        double resultado = 0;
        while (opcao == 0 || opcao > 5) {
            Console.WriteLine("Número inválido, digite um número que faça parte das opções");
            opcao = int.Parse(Console.ReadLine());

        }
        if (opcao == 5) {
            Console.WriteLine("Informe um número");
            double raiz = double.Parse(Console.ReadLine());
            double raizQ = Math.Sqrt(raiz);
            Console.WriteLine(raizQ);

        }
        else {
            Console.WriteLine("Informe o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número");
            double num2 = double.Parse(Console.ReadLine());



            switch (opcao) {

                case 1: {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2: {

                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 3: {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 4: {
                        resultado = Divisao(num1, num2);
                        break;
                    }

            }
        }
        Console.WriteLine(resultado);

    }
    public static double Adicao(double num1, double num2) {

        double resultado = num1 + num2;
        return resultado;
    }
    public static double Multiplicacao(double num1, double num2) {

        double resultado = num1 * num2;
        return resultado;

    }
    public static double Subtracao(double num1, double num2) {
        double resultado = num1 - num2;
        return resultado;

    }

    public static double Divisao(double num1, double num2) {
        double resultado = num1 / num2;
        return resultado;

    }

}


