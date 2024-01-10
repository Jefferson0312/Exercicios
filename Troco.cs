using System;
using System.Numerics;
class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Quantidade comprada: ");
        double qtd = double.Parse(Console.ReadLine());

        Console.WriteLine("Preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor recebido: ");
        double vlrRecebido = double.Parse(Console.ReadLine());

        double total = TotalCompra(preco, qtd);
        double troco = Troco(vlrRecebido, total);

        if (vlrRecebido < total) {

            double rest = total % vlrRecebido;

            Console.WriteLine("Valor insuficiente, restam R$ {0:N2}", rest);
        }

        Console.WriteLine("Total da compra = R$ {0:N2}", total);
        Console.WriteLine("Troco = R$ {0:N2}", troco);
    }
    public static double TotalCompra(double qtd, double preco) {
        double total = preco * qtd;
        return total;
    }
    public static double Troco(double total, double vlrRecebido) {
        
        
        double troco = total - vlrRecebido;
        return troco;
    
    } 
}