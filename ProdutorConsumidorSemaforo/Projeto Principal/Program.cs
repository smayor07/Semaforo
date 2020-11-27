using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projeto_Principal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=========== PRODUTOR/CONSUMIDOR - SEMÁFORO ===========");
            Console.WriteLine("======================================================");
            Console.WriteLine("========== EQUIPE: Amanda Lapa e Sebá Mayor ==========");
            Console.WriteLine("======================================================");
            Console.WriteLine("");

            SemaforoClass SEM = new SemaforoClass();
            Console.Write("Número de valores a serem produzidos:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {
                SEM.INICIA();
            }

            Console.WriteLine("SOMATÓRIO FINAL:" + SEM.GetSoma());
            Console.WriteLine("=======================================================");
            Console.ReadKey();
        }
    }
}
