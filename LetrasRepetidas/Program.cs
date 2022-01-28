using System;
using System.Linq;

namespace LetrasRepetidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] duplicados = { "abracadabra", "allottee", "assessee", "kelless", "keenness" };

            var anterior = " ";

            foreach (var palavra in duplicados)
            {
                var letras = from
                    carac in palavra
                           select carac;

                foreach (var item in letras)
                {
                   if (item != Convert.ToChar(anterior))
                    {
                        Console.Write(item);
                    }
                    anterior = Convert.ToString(item);
                }
                anterior = " ";
                Console.WriteLine("");
            }
        }

    }
}
