namespace exe09
{
    public interface IMetodoPagamento
    {

        public bool realizarPagamento(double valor); 
        public double verificarStatus(ContaV conta);
    }
}