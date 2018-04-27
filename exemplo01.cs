using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class exemplo01
    {
        public exemplo01()
        {
            string[] mortesdofilme = new string[5];
            // forma old
            // mortesdofilme[0] = "Tony Stark";

            // armazena as informações no vetor
            for (int i = 0; i < mortesdofilme.Length; i++)
            {
                Console.WriteLine("Digite o nome da pessoa que morre no filme: ");
                mortesdofilme[i] = Console.ReadLine();
            }
            // apresentar as informações do vetor
            for (int i = 0; i < mortesdofilme.Length; i++)
            {
                Console.WriteLine("Nome: " + mortesdofilme[i]);   
            }

        }
    }
}
