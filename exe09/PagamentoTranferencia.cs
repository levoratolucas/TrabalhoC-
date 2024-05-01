namespace exe09
{
    public class PagamentoTransferencia : IMetodoPagamento
    {


        public bool realizarPagamento(){
             return true;
        } 
        public bool verificarStatus(string conta){
            return true;
        }

    }
}