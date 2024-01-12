using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
class Program {
    public static void Main(string[] args) {

        double raio;
        double area = 0;

        Console.WriteLine("Digite o valor do raio do círculo:");
        raio = double.Parse(Console.ReadLine());

        area = Raio(raio, area);

        Console.WriteLine("Área = {0:N2}", area);
    }

    public static double Raio(double raio, double area) {
        double area1 = Math.PI * (raio * raio);
        return area1;
    }
}