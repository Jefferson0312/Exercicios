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

        int y = 1;
        int x = 0;

        while (x != 0 || y != 0) {

            Console.WriteLine("Digite o valor de X:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y:");
            y = int.Parse(Console.ReadLine());


            if (x > 0 && y > 0) {
                Console.WriteLine("Quadrante 1");
            }

            else if (x < 0 && y > 0) {
                Console.WriteLine("Quadrante 2");
            }

            else if (x < 0 && y < 0) {
                Console.WriteLine("Quadrante 3");
            }

            else if (x > 0 && y < 0) {
                Console.WriteLine("Quadrante 4");
            }

            else if (x > 0 || x < 0 && y == 0) {
                Console.WriteLine("Eixo X");
            }

            else {
                Console.WriteLine("Eixo Y");
            }

        }
        Console.WriteLine("Origem");
    }
}