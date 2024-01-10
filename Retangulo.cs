using System;
using System.Numerics;
class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Base do retângulo:");
        double base1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Altura do retângulo:");
        double altura = double.Parse(Console.ReadLine());

        double area = AreaRetangulo(base1, altura);
        double perimetro = Perimetro(base1, altura);
        double diagonal = Diagonal(base1, altura);

        Console.WriteLine("Área do retângulo = {0:N2}", area);
        Console.WriteLine("Perímetro do retângulo = {0:N2}", perimetro);
        Console.WriteLine("Diagonal do retângulo = {0:N2}", diagonal);


    }
    public static double AreaRetangulo(double base1, double altura) {
        double area = base1 * altura;
        return area;
    }

    public static double Perimetro(double base1, double altura) {
        double perimetro = 2 * (base1 + altura);
        return perimetro;
    }

    public static double Diagonal(double base1, double altura) {
        double diagonal = Math.Sqrt(base1 * base1 + altura * altura);
        return diagonal;
    }
}