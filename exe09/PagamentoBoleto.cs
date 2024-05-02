namespace exe09
{
    public class PagamentoBoleto : IMetodoPagamento
    {
public bool pago {get;set;}
public double dinheiro {get;set;}

        public bool realizarPagamento(double valorPagar){

             return dinheiro == valorPagar;
        } 
        public double verificarStatus(ContaV conta){
            return conta.valor;
        }

    }
}