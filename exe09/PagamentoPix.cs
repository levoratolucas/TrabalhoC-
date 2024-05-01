namespace exe09
{
    public class PagamentoPix : IMetodoPagamento
    {


        public bool realizarPagamento(){
             return true;
        } 
        public bool verificarStatus(string conta){
            return true;
        }

    }
}