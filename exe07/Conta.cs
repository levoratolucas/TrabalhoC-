namespace exe07
{
      public class Conta 
    {
        public string titular {get;set;}
        public double saldo {get;set;}
        public int numeroConta { get; set; }
        
        public Conta (Pessoa pessoa){
            this.titular=pessoa.nome;
        }
        public Conta (Empresa empresa){
            this.titular=empresa.cnpj;
        }       
    }
}