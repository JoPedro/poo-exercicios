using System;

namespace IEx05
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite a base e a altura do retângulo");
			double b = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());

			double area = b * h;
			double perim = b * 2 + h * 2;
			double diag = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

			Console.WriteLine();
			Console.WriteLine("Área = " + String.Format("{0:0.00}", area) + " - Perímetro = " + String.Format("{0:0.00}", perim) + " - Diagonal = " + String.Format("{0:0.00}", diag));
        }
    }
}
