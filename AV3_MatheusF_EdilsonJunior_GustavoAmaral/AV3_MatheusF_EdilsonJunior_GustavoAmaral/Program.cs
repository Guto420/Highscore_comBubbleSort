using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV3_MatheusF_EdilsonJunior_GustavoAmaral
{
    class Program
    {
        /*public static string jogador1, jogador2, jogador3, jogador4, jogador, jogador6, jogador7, jogador8, jogador9, jogador10;
        public Class2 ponto;
        public Class2 nome;*/
        


        static void Main(string[] args)
        {

            #region
            int[] pontos = { 3, 5, 6, 7, 8, 9, 10, 13, 15, 18 };
            int indice = 0;


            for (int write = 0; write < pontos.Length; write++)
            {
                for (int sort = 0; sort < pontos.Length - 1; sort++)
                {
                    if (pontos[sort] < pontos[sort + 1])
                    {
                        indice = pontos[sort + 1];
                        pontos[sort + 1] = pontos[sort];
                        pontos[sort] = indice;

                    }
                }
            }
            for (int write = 0; write < pontos.Length; write++)

                Console.Write("{0}" + " ", pontos[write]);
            Console.ReadLine();

            #endregion
   
        }
    }
}
