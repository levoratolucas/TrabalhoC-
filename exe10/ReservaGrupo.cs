namespace exe10
{
    public class ReservaGrupo : Reserva
    {
        public string[] titulares { get; set; }
        public double valorGrupoPromocional { get;set; }


        public ReservaGrupo(string[] titulares)
        {
            this.titulares = new string[titulares.Length];
            this.titulares = titulares;
        }
        public void valorGrupo()
        {
            int grupo = titulares.Length;
            if (grupo >2 && grupo <11)
            {
                this.valorGrupoPromocional = this.valor * 0.9 * grupo;
            }else if(grupo >10 ){
                this.valorGrupoPromocional = this.valor * 0.85 * grupo;
            }
        }
    }
}