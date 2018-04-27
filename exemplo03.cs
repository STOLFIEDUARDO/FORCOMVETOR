using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class exemplo03
    {
        public exemplo03()
        {
            Console.WriteLine("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());
            string[] fazendas = new string [quantidadedeRegistros];
            int[] quantidadedeporcos = new int[quantidadedeRegistros];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome da fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("Quantidade de suínos: ");
                quantidadedeporcos[i] = Convert.ToInt32(Console.ReadLine());

            }

            // maior quantidade de suínos
            int maiorquantidadesuinos = int.MinValue;
            string fazendamaiorquantidadedesuinos = "";
            for (int i = 0; i < quantidadedeporcos.Length; i++)
            {
                if (quantidadedeporcos[i] > maiorquantidadesuinos )
                {
                    maiorquantidadesuinos = quantidadedeporcos[i];
                    fazendamaiorquantidadedesuinos = fazendas[i];
                } 

            }

            Console.WriteLine("Fazenda com a maior quantidade de suínos: " + fazendamaiorquantidadedesuinos + "\n" + "contém : " + maiorquantidadesuinos);

            //fazenda menor nome 
            string menornome = "";
            for (int i = 0; i < 10000; i++)
            {
                if (i % 2 == 0)
                {
                    menornome = menornome + "a";

                }
                else
                {
                    menornome = menornome + "k";
                }
            }

            for (int i = 0; i < fazendas.Length; i++)
            {
                if (fazendas[i].Length < menornome.Length)
                {
                    menornome = fazendas[i];
                }
            }

            Console.WriteLine("Fazenda com menor nome: " + menornome);


        }
    }
}
