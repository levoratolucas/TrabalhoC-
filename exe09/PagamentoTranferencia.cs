namespace exe09
{
    public class PagamentoTransferencia : IMetodoPagamento
    {
        public string senha {get;set;} = "123";
        public double saldoContaBancaria {get;set;}
        public bool autenticado = false;
        public void autenticador(string senha){
            this.autenticado= senha == this.senha;
        }
        public bool realizarPagamento(double valorPagar){
            if(this.autenticado==true && saldoContaBancaria >= valorPagar){
                this.saldoContaBancaria -= valorPagar;
                this.autenticado=false;
            return true;
            }else{
                return false;
            }
        }  
        public double verificarStatus(ContaV conta){
            return conta.valor;
        }

    }
}