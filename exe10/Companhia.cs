namespace exe10
{
    public class Companhia
    {
        public string[] origens { get; set; }
        public string[] destinos { get; set; }
        public string[] datas { get; set; }
        private List<ReservaCod> reservas { get; set; }

        public Companhia(string[] qtdOrigens, string[] qtdDestinos, string[] qtDdatas)
        {
            origens = qtdOrigens;
            destinos = qtdDestinos;
            datas = qtDdatas;
            reservas = new List<ReservaCod>();
        }
        public string registrarReserva(IReserva reserva, string data, string origem, string destino)
        {
            bool[] valido = new bool[3];
            foreach (string origem_ in this.origens)
            {
                if (origem == origem_) { valido[0] = true; break; }
            }
            foreach (string destino_ in this.destinos)
            {
                if (destino == destino_) { valido[1] = true; break; }
            }
            foreach (string data_ in this.datas)
            {
                if (data == data_) { valido[2] = true; break; }
            }
            if (valido[0] && valido[1] && valido[2])
            {
                int cod = reservas.Count + 1;
                ReservaCod reservaCod = reserva.reservarVoo(origem, destino, data, cod,true);
                this.reservas.Add(reservaCod);
                return "Reserva registrada com sucesso - Data: " + data + ", Origem: " + origem + ", Destino: " + destino;
            }
            return "Não foi possível registrar a reserva devido a origem, destino ou data inválidos.";
        }
    }
}