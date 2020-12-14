using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //real e dolar
            Console.Write($"Digite o valor que deseja converter (Dolar): ");
            float realToDollar = float.Parse(Console.ReadLine());
            Console.Write($"Dolar para real: ");
            Console.WriteLine(Conversor.DolarParaReal(realToDollar));
            Console.Write($"Real para dolar: ");
            Console.WriteLine(Conversor.RealParaDolar(realToDollar));
            //real e euro
            Console.Write($"-------------------------\nDigite o valor que deseja converter (Euro): ");
            float realToEuro = float.Parse(Console.ReadLine());
            Console.Write($"Dolar para real: ");
            Console.WriteLine(Conversor.EuroParaReal(realToEuro));
            Console.Write($"Real para dolar: ");
            Console.WriteLine(Conversor.RealParaEuro(realToEuro));
        }
    }
}
