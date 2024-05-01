namespace exe08
{
    public class Curso
    {
        public string nome { get; set; }
        public string fundacao { get; set; }
        public string duracao { get; set; }
        public int nivel { get; set; }
        public double frequencia { get; set; }

        public Curso(string nome, int nivel)
        {
            this.nome = nome;
            this.nivel = nivel;
        }
    }
}