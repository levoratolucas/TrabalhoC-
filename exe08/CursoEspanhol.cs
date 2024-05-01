namespace exe08
{
    public class CursoEspanhol : Curso
    {
        public CursoEspanhol(string nome, int nivel) : base(nome, nivel) { }
        public bool apto(){
            switch(this.nivel){
                case 1 :  return frequencia >= 70 ; break;
                case 2 :  return frequencia >= 80; break;
                case 3 :  return frequencia >= 90; break;
                default: return false;
            }
        }    
    }
}