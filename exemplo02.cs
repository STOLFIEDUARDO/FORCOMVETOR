using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class exemplo02
    {
        public exemplo02()
        {
            int[] levelNoLoL = new int[5];

            for (int i = 0; i < levelNoLoL.Length; i++)
            {
                Console.WriteLine("Digite o seu level no lol: ");
                levelNoLoL[i] = Convert.ToInt32(Console.ReadLine());
            }
            int somalevels = 0;
            for (int i = 0; i < levelNoLoL.Length; i++)
            {
                somalevels = levelNoLoL[i] + somalevels;

            }
            double medialevels = somalevels / levelNoLoL.Length;
            Console.WriteLine("Média: " + medialevels);

            

            

        }
    }
}
