namespace exe07
{
    public class ContaPoupanca : Conta
    {
        public double rendimento {get;set;}
        public ContaPoupanca(Pessoa pessoa) : base(pessoa)
        {
            this.titular = pessoa.nome;
        }
        public void calcularRendimento(){
            // logica de calculo não foi o chat eu mesmo fiz esse comentario ASS:Lucas Levorato
        }
    }
}