using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Quantos quartos estão alugados? ");
            int n = int.Parse(Console.ReadLine());

            //criando um vetor de 10 da classe alguel
            Aluguel[] vet = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hóspede #" + (i+1) + ";");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Quarto: ");
                int quartos = int.Parse(Console.ReadLine());

                //instaciando as propriedades no lugar dos quartos escolhidos pelo usuário
                vet[quartos] = new Aluguel(nome, email, quartos);

                Console.WriteLine("---------------------------");

               
            }

            Console.WriteLine("Quartos ocupados:");

            //for para conferir qual quarto está vazio e qual está ocupado
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(vet[i]);

                }
            }
        }
    }
}
