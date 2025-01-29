using System;

namespace BEECROWD_1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gols;
            int escolha, inter, gremio, count, vInter, vGremio, empate;

            count = 0;
            vInter = 0;
            vGremio = 0;
            empate = 0;
            do
            {
                
                gols = Console.ReadLine().Split();
                inter = int.Parse(gols[0]);
                gremio = int.Parse(gols[1]);

                if(inter > gremio)
                {
                    vInter += 1;
                }
                else if (gremio > inter) 
                {
                    vGremio += 1;
                }
                else
                {
                    empate += 1;
                }
                
                count ++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha == 1);

            Console.WriteLine(count + " grenais");
            Console.WriteLine("Inter:" + vInter);
            Console.WriteLine("Gremio:" + vGremio);
            Console.WriteLine("Empates:" + empate);
            if(vInter > vGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
