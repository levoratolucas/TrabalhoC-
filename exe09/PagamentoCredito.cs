namespace exe09
{
    public class PagamentoCredito : IMetodoPagamento
    {

public string cartao;
public string banco;
double valorDebitar {get;set;}
public double credito;
        public bool realizarPagamento(double valorPagar){
            if(valorPagar > credito){
                return false;
            }else{
                this.credito -= valorPagar;
            return true;
            }
        }  
        public double verificarStatus(ContaV conta){
            return conta.valor;
        }

    }
}