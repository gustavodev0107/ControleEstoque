public class ControleEstoque
{
    private const int CapacidadeMaxima = 100; 
    private Produto[] produtos;
    private int quantidadeProdutos;

    public ControleEstoque()
    {
        produtos = new Produto[CapacidadeMaxima];
        quantidadeProdutos = 0;
    }

    public void AdicionarProduto(Produto produto)
    {
        if (quantidadeProdutos >= CapacidadeMaxima)
        {
            Console.WriteLine("Não é possível adicionar mais produtos. Estoque cheio.");
            return;
        }

        produtos[quantidadeProdutos++] = produto;
        Console.WriteLine("Produto adicionado!");
    }

    public void ListarProdutos()
    {
        if (quantidadeProdutos == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        for (int i = 0; i < quantidadeProdutos; i++)
        {
            Console.WriteLine($"{i + 1}. {produtos[i]}");
        }
    }

    public void RemoverProduto(int posicao)
    {
        if (posicao < 1 || posicao > quantidadeProdutos)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        // Deslocar elementos para preencher o espaço do produto removido
        for (int i = posicao - 1; i < quantidadeProdutos - 1; i++)
        {
            produtos[i] = produtos[i + 1];
        }

        // Reduzir a quantidade de produtos
        quantidadeProdutos--;
        Console.WriteLine("Produto removido!");
    }

    public void EntradaEstoque(int posicao, int quantidade)
    {
        if (posicao < 1 || posicao > quantidadeProdutos)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        produtos[posicao - 1].QuantidadeEmEstoque += quantidade;
        Console.WriteLine("Entrada de estoque registrada!");
    }

    public void SaidaEstoque(int posicao, int quantidade)
    {
        if (posicao < 1 || posicao > quantidadeProdutos)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        var produto = produtos[posicao - 1];
        if (produto.QuantidadeEmEstoque < quantidade)
        {
            Console.WriteLine("Quantidade insuficiente no estoque.");
            return;
        }

        produto.QuantidadeEmEstoque -= quantidade;
        Console.WriteLine("Saída de estoque registrada!");
    }
}
