using System;

namespace sistema_concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                //Mostra um menu de opções para o usuário
                Console.WriteLine("Digite a opção");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Carro");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Listar Carros Vendidos");
                Console.WriteLine("9 - Sair");
                opcao = Int16.Parse(Console.ReadLine());
                
                //Recebe opção do usuário
                switch (opcao) 
                {
                    case 1:
                        Cliente c1 = new Cliente();
                        c1.CadastrarCliente();
                        break;

                    case 2:
                        Carro carro = new Carro();
                        carro.CadastroCarro();
                        break;

                    case 3:
                        Venda venda =new Venda();
                        venda.ListarVenda();
                        break;

                    case 4:
                        ExtratoCliente();
                        break;
                }
            }
            while (opcao != 9);
        }

    }
}
    
