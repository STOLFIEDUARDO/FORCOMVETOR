using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] nomes = new string[25];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                nomes[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);
            }
        }
    }
}
