using System;

namespace IEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro nome:");
            string nome = Console.ReadLine();

			Console.WriteLine();
            Console.WriteLine("Bem-vindo ao C#, " + nome);
        }
    }
}
