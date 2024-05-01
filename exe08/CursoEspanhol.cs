namespace exe08
{    public class CursoEspanhol : Curso
    {
        public string nome { get; set; }
        public string fundacao { get; set; }
        public string duracao { get; set; }
        public CursoEspanhol(string nome):base(nome){}
    }
}