using System;
using System.Globalization;

namespace TP3_SAMUELBELO_CSHARP_S1
{
    class Program
    {
        static Biblioteca biblioteca = new Biblioteca();
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("++++ Biblioteca :P ++++");
                Console.WriteLine("1 .... Adicionar pessoa");
                Console.WriteLine("2 .... Pesquisar pessoa");
                Console.WriteLine("3 .... Sair");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");

                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionaPessoa();
                        break;
                    case 2:
                        PesquisaPessoa();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:

                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
        }
        private static void PesquisaPessoa()
        {
            Console.WriteLine("Você selecionou 'Pesquisar pessoa' ");
            Console.WriteLine("Escreva o nome da busca: ");
            string nome = Console.ReadLine();

            biblioteca.Pesquisar(nome);
        }

        private static void AdicionaPessoa()
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Você selecionou 'Adicionar pessoa' ");
            Console.WriteLine("Escreva o seu nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Escreva o seu sobrenome: ");
            p.Sobrenome = Console.ReadLine();

            Console.WriteLine("Escreva sua data de nascimento no formato dd/MM/yyyy: ");
            string inputDate = Console.ReadLine();
            DateTime dataNascimento;
            DateTime.TryParseExact(inputDate, "dd/MM/yyyy", null, DateTimeStyles.None, out dataNascimento);
            p.Aniversario = dataNascimento;


            biblioteca.Inserir(p);
        }
    }
}
