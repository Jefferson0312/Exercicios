using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

class Program {
    public static void Main(string[] args) {

        double codigoProduto, qtd;
        double valorPago = 0;

        Console.WriteLine("Código do produto comprado:");
        codigoProduto = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade comprada:");
        qtd = double.Parse(Console.ReadLine());

        switch (codigoProduto) {
            case 1: {
                    valorPago = Prod1(valorPago, qtd);
                    break;
                }
            case 2: {
                    valorPago = Prod2(valorPago, qtd);
                    break;
                }

            case 3: {
                    valorPago = Prod3(valorPago, qtd);
                    break;
                }

            case 4: {
                    valorPago = Prod4(valorPago, qtd);
                    break;
                }

            case 5: {
                    valorPago = Prod5(valorPago, qtd);
                    break;
                }

        }

        Console.WriteLine(valorPago);
    }
    public static double Prod1(double valorPago, double qtd) {
        valorPago = 5 * qtd;
        return valorPago;
    }

    public static double Prod2(double valorPago, double qtd) {
        valorPago = 3.50 * qtd;
        return valorPago;
    }

    public static double Prod3(double valorPago, double qtd) {
        valorPago = 4.80 * qtd;
        return valorPago;
    }

    public static double Prod4(double valorPago, double qtd) {
        valorPago = 8.90 * qtd;
        return valorPago;
    }

    public static double Prod5(double valorPago, double qtd) {
        valorPago = 7.32 * qtd;
        return valorPago;
    }
}