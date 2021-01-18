using System;

namespace IEx06
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
			string tempo = Console.ReadLine();

			int hh = int.Parse(tempo.Substring(0, 2));
			int mm = int.Parse(tempo.Substring(3, 2));
			int ss = int.Parse(tempo.Substring(6, 2));

			int qtd_seg = hh * 3600 + mm * 60 + ss;
			int km_perc = 3 * qtd_seg;
			
			Console.WriteLine();
			Console.WriteLine("A luz percorreu " + km_perc + "00000 km nesse intervalo");
        }
    }
}
