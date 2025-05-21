using System;

public class Program
{
    static void Main()
    {
        var controleEstoque = new ControleEstoque();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("[1] Novo [2] Listar Produtos [3] Remover Produtos [4] Entrada Estoque [5] Saída Estoque [0] Sair");
            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informe o nome do Produto:");
                    string nome = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Informe o preço:");
                    double preco = 0;
                    string precoInput = Console.ReadLine() ?? string.Empty;
                    if (!double.TryParse(precoInput, out preco))
                    {
                        Console.WriteLine("Preço inválido. O preço será considerado como 0.");
                    }

                    Console.WriteLine("Informe o autor(a):");
                    string autor = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Informe o Gênero:");
                    string genero = Console.ReadLine() ?? string.Empty;

                    var produto = new Produto(nome, preco, autor, genero);
                    controleEstoque.AdicionarProduto(produto);
                    break;

                case "2":
                    controleEstoque.ListarProdutos();
                    break;

                case "3":
                    Console.WriteLine("Informe a posição do produto a ser removido:");
                    string posicaoRemoverInput = Console.ReadLine() ?? string.Empty;
                    if (int.TryParse(posicaoRemoverInput, out int posicaoRemover))
                    {
                        controleEstoque.RemoverProduto(posicaoRemover);
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Informe a posição do produto:");
                    string posicaoEntradaInput = Console.ReadLine() ?? string.Empty;
                    if (int.TryParse(posicaoEntradaInput, out int posicaoEntrada))
                    {
                        Console.WriteLine("Informe a quantidade de Entrada:");
                        string quantidadeEntradaInput = Console.ReadLine() ?? string.Empty;
                        if (int.TryParse(quantidadeEntradaInput, out int quantidadeEntrada))
                        {
                            controleEstoque.EntradaEstoque(posicaoEntrada, quantidadeEntrada);
                        }
                        else
                        {
                            Console.WriteLine("Quantidade inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Informe a posição do produto:");
                    string posicaoSaidaInput = Console.ReadLine() ?? string.Empty;
                    if (int.TryParse(posicaoSaidaInput, out int posicaoSaida))
                    {
                        Console.WriteLine("Informe a quantidade de Saída:");
                        string quantidadeSaidaInput = Console.ReadLine() ?? string.Empty;
                        if (int.TryParse(quantidadeSaidaInput, out int quantidadeSaida))
                        {
                            controleEstoque.SaidaEstoque(posicaoSaida, quantidadeSaida);
                        }
                        else
                        {
                            Console.WriteLine("Quantidade inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;

                case "0":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
