namespace exe09
{
    public interface IMetodoPagamento
    {

        public bool realizarPagamento(); 
        public bool verificarStatus(string conta);
    }
}