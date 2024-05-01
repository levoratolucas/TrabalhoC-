// Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. Os métodos devem alterar o estado do objeto instanciado
namespace exe04
{
    public class Produto : IProduto
    {
        public string fornecedor { get; set; }
        public string nome { get; set; }
        public int quantidadeEmEstoque { get; set; }
        public double preco { get; set; }
        public void adicionar(int qtd)
        {
            if (qtd > 0)
            {
                this.quantidadeEmEstoque += qtd;
                Console.WriteLine( "Adicionado");
            }
            else
            {
                Console.WriteLine( "Não é possível adicionar quantidade negativa");
            }
        }
        public void remover(int qtd)
        {
            if (qtd < 0)
            {
                qtd *=-1;
            }
                this.quantidadeEmEstoque -= qtd;
                 Console.WriteLine("Removido {0} itens", qtd);
            
        }
        public double calcularValorTotal()
        {
            return this.quantidadeEmEstoque * this.preco;
        }
        public bool autenticador(string fornecedor)
        {
            return this.fornecedor == fornecedor;
        }
    }
}