using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());
            double[] preços = new double[quantidadedeRegistros];

            for (int i = 0; i < preços.Length; i++)
            {
                
                Console.Write("Preço: ");
                preços[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.Clear();
            double totalpreço = 0;
            for (int i = 0; i < preços.Length; i++)
            {
                Console.WriteLine("Preços: " + preços[i]);            
                
                totalpreço = preços[i] + totalpreço;
            }
            Console.WriteLine("Total Preços: " + totalpreço);
        }
    }
}
