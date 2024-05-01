namespace exe08
{
    // 8.	Crie uma aplicação para uma escola de idiomas que oferece diferentes tipos de cursos, como inglês, espanhol e francês. Utilize herança para representar a relação entre as classes de cursos e implemente métodos específicos para cada tipo de curso, como calcular a média de notas para cursos avançados e gerar certificados para cursos concluídos.

    public class Curso
    {
        public string nome { get; set; }
        public string fundacao { get; set; }
        public string duracao { get; set; }
        
        public Curso(string nome){
            this.nome=nome;
        }
    }
}