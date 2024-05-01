namespace exe08
{    public class CursoIngles : Curso
    {
        public bool mensalidade { get; set; }= false;
        public CursoIngles(string nome, int nivel) : base(nome, nivel){}
        public bool apto(){
           return this.mensalidade == true && this.frequencia > 60;
        } 
    }
}