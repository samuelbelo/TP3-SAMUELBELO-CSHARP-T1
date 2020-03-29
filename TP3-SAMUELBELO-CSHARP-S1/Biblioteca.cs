using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_SAMUELBELO_CSHARP_S1
{
    class Biblioteca
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void Inserir(Pessoa p)
        {
            pessoas.Add(p);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
        }

        public void Pesquisar(string n)
        {
            bool condicao = false;
            if (pessoas.Count >= 0)
            {
                condicao = true;
            }

            if (condicao)
            {
                foreach (var x in pessoas)
                {
                    if (x.Nome.Contains(n))
                    {
                        Console.WriteLine($"Pessoa encontrada: {x.Nome} {x.Sobrenome} \n Data de nascimento: {x.Aniversario}");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        condicao = false;
                    }
                    else
                    {
                        Console.WriteLine("Pessoa nao encontrada");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        condicao = false;
                    }

                }


            }
            else
            {
                Console.WriteLine("Não existe cadastro ativo no sistema.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }



        }
    }
}
