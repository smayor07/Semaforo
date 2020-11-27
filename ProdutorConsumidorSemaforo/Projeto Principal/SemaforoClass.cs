using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projeto_Principal
{
    class SemaforoClass
    {
        private Semaphore SEM;
        private int BUFFER = 0;
        private int SOMA = 0;

        public void INICIA()
        {
            SEM = new Semaphore(1, 2);
            Thread T1 = new Thread(Produtor);
            Thread T2 = new Thread(Consumidor);

            T1.Start();
            T2.Start();

            Thread.Sleep(1000);
            SEM.Release();
        }

        public void Produtor()
        {
            BUFFER++;
            Console.WriteLine("Produzindo valor............");
            Console.WriteLine("Produzido - VALOR: " + BUFFER);
            Console.WriteLine("----------------------------");
            SEM.WaitOne();
        }

        public void Consumidor()
        {
            SOMA += BUFFER;
            Console.WriteLine("Consumindo valor............");
            Console.WriteLine("Consumido - VALOR: " + BUFFER);
            Console.WriteLine("----------------------------");
            SEM.WaitOne();
        }

        public int GetSoma()
        {
            return SOMA;
        }

    }
}
