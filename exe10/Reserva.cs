namespace exe10{
    public abstract class Reserva : IReserva {
        public string origem {get;set;}
        public string destino {get;set;}
        public int cod {get;set;}
        public string data {get;set;}
        public bool status {get;set;}
        public double valor {get;set;}
        public int dias {get;set;}
        public ReservaCod reservarVoo(string origem,string destino,string data,int cod,bool status){
            this.destino=destino;
            this.origem=origem;
            this.data=data;
            this.cod=cod;
            this.status=status;
            ReservaCod reserva = new ReservaCod(cod);
            return reserva;
        } 
        public string cancelarReserva(){return "Essa modalidade não pode cancelar sem taxa";}
        public string verificarStatusReserva(){return this.status ? "ativa" : "inexistente";}
        
    }
}