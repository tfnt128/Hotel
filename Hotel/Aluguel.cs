using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Aluguel
    {
        //criando as propriedades
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quartos { get; set; }

        //criando construtor vazio
        public Aluguel()
        {
        }

        //criando construtor personalizado
        public Aluguel(string nome, string email, int quartos)
        {
            Nome = nome;
            Email = email;
            Quartos = quartos;
        }

        //conversão para string
        public override string ToString()
        {
            return Quartos + ": " + Nome + ", " + Email;
        }
    }
}
