namespace exe10
{
    public class ReservaFlexicivel : Reserva
    {
        public string titular {get;set;}
        public string cancelarReserva(){
            this.status=false;
            return "cancelada";
        }
    }
}