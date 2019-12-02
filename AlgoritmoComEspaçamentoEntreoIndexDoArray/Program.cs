using System;

namespace AlgoritmoComEspaçamentoEntreoIndexDoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 4, 3, 2, 1 };
            int inde = 0;
            string espac = PegarEspacos(num.Length);

            foreach (int nu in num)
            {

                Console.WriteLine(espac + num[inde]);
                inde = inde + 1;
                espac = PegarEspacos(num.Length - inde);

            }

            Console.ReadKey();
        }

        public static string PegarEspacos(int quantidadeDeEspacos)
        {
            string totalEspacos = "";

            for (int i = 0; i < quantidadeDeEspacos; i++)
            {

                totalEspacos = totalEspacos + "   ";

            }

            return totalEspacos;
        }
    }
}
