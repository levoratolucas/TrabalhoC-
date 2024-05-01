namespace exe05
{
    // 5.	Implemente um sistema para uma locadora de filmes. Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação). Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filme está disponível para locação. Não há necessidade de implementar rotinas de bancos de dados.
    public class Locadora
    {
        public List<Filme> filmes;
        public Locadora()
        {
            filmes = new List<Filme>();
        }
        public void addFilme(Filme filme){
            this.filmes.Add(filme);
        }
        public Filme GetFilme(string titulo){
            foreach(Filme filme in this.filmes){
                if(filme.Titulo==titulo){
                    return filme;
                }
            }
            return null;
        }
        public void registrar(Filme filme)
        {
            filme.Disponivel=false;
        }
        public void devolucao(Filme filme)
        {
            filme.Disponivel=true;
        }
        public bool verificar(Filme filme)
        {
            if (filme.Disponivel == true)
            {
                return true;
            }
            else { return false; }

        }

    }


}