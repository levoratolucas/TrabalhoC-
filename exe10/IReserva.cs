namespace exe10{
    // 10.	Projete um sistema de reservas de voos para uma companhia aérea. Crie uma interface IReserva com métodos para reservar um voo, cancelar uma reserva e verificar o status da reserva. Implemente classes para diferentes tipos de reservas, como reserva de voo regular, reserva de voo com upgrade de classe e reserva de voo para grupos grandes. Utilize a interface para garantir a interoperabilidade entre os diferentes tipos de reservas.
    public interface IReserva{
        public ReservaCod reservarVoo(string origem,string destino,string data,int cod, bool status); 
        public string cancelarReserva();
        public string verificarStatusReserva();
    }
}