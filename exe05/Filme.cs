namespace exe05
{
    // 5.	Implemente um sistema para uma locadora de filmes. Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação). Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filme está disponível para locação. Não há necessidade de implementar rotinas de bancos de dados.
    public class Filme
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public double Duracao { get; set; }
        public bool Disponivel  { get; set; } = true;

       

    }

}