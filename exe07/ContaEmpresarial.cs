namespace exe07
{
    public class ContaEmpresarial : Conta
    {
        public double limite {get;set;}
        public double chequeEspecial {get;set;}
        public double credito {get;set;}
        public double saldoMinimo {get;set;}
        public ContaEmpresarial(Empresa empresa,double saldoMinimo, double deposito): base(empresa)
        {
            this.saldoMinimo=saldoMinimo;
            this.saldo = deposito;
        }
        public double verificarSaldoMinimo(){
            return this.saldoMinimo;
        }
    }
}