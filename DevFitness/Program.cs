using System;

namespace DevFitness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome.");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura.");
            var altura = Console.ReadLine();

            Console.WriteLine("Digite seu peso.");
            var peso = Console.ReadLine();

            var listaRefeicoes = new List<Refeicao>();
           
            var opcao = "-1";

            

               while (opcao != "0")
                {

                ExibirOpcoes();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.WriteLine($"Nome:{nome}, Altura: {altura}, Peso: {peso}");

                        break;

                    case "2":

                        // Cadastrar(new List<Refeicao>());

                        break;

                    case "3":

                        //ListarRefeicoes();

                        break;

                    default:

                        Console.WriteLine("Por favor, digite outra opção.");

                        break;


                }
            }
            

         
            Console.WriteLine("fechando o app.");

            Console.ReadLine();
        }

        public static void ExibirOpcoes()
        {
            Console.WriteLine("--- Seja Bem-vindo ao DevFitness---");
            Console.WriteLine("1- Exibir detalhes de usuário.");
            Console.WriteLine("2- Cadastrar nova refeição.");
            Console.WriteLine("3- Listar todas refeições.");
            Console.WriteLine("0 - Finalizar aplicação.");
        }

        // public static void Cadastrar(List<Refeicao> refeicoes)









    }
}
