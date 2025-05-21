public class Produto
{
    public string Nome { get; set; }
    public double Preço { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }

    public Produto(string nome, double preço, string autor, string genero)
    {
        Nome = nome;
        Preço = preço;
        Autor = autor;
        Genero = genero;
        QuantidadeEmEstoque = 0;
    }

    public override string ToString()
    {
        return $"{Nome} ({Preço}) – {QuantidadeEmEstoque} no estoque";
    }
}
