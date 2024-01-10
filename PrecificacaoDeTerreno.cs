using System;
using System.Numerics;
class Program {
    public static void Main(string[] args) {


        Console.WriteLine("Informe a largura do terreno:");
        double largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o comprimento do terreno:");
        double comprimento = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor do metro quadrado:");
        double metroQuadrado = double.Parse(Console.ReadLine());

        double areaTerreno = AreaTerreno(largura, comprimento);
        double valorTerreno = ValorTerreno(areaTerreno, metroQuadrado);

        Console.WriteLine("Preço do terreno = {0:N2}", valorTerreno);
        Console.WriteLine("Área do terreno = {0:N2}", areaTerreno);

    }
    public static double AreaTerreno(double largura, double comprimento) {

        double area = largura * comprimento;
        return area;
    }

    public static double ValorTerreno(double area, double metroQuadrado) {
        double valorTerreno = area * metroQuadrado;
        return valorTerreno;
    }

}