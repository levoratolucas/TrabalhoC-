namespace exe07
{
    public class ContaCorrente : Conta
    {
        public double limite { get; set; }
        public double chequeEspecial { get; set; }
        public double credito { get; set; }
        public ContaCorrente(Pessoa pessoa) : base(pessoa)
        {
        }
    }
}