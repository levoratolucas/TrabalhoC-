namespace exe09{
    public class ContaV{
        public double valor {get;set;}
        public string conta {get;set;}


        public bool cobrar(IMetodoPagamento metodoPagamento){
            return metodoPagamento.verificarStatus(this.conta);
        }
    }
}