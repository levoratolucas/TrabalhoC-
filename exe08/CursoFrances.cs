namespace exe08
{    public class CursoFrances : Curso
    {
        public double notas { get; set; }
        public CursoFrances(string nome, int nivel) : base(nome, nivel){}
        public bool apto(){
            switch(this.nivel){
                case 1 :  return frequencia >= 70 && notas>=60 ; break;
                case 2 :  return frequencia >= 80 && notas>=65; break;
                case 3 :  return frequencia >= 90 && notas>=70; break;
                default: return false;
            }
        } 
    }
}